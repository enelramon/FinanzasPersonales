using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace FinanzasPersonales.Consultas
{
    public partial class cGastos : Form
    {
        private int datoEncontrado;

        public int DatoEncontrado
        {
            get { return datoEncontrado; }
        }

        public cGastos()
        {
            InitializeComponent();
        }

        private void cGastos_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Gastos gasto = new Gastos();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0) //IdGasto
            {
                //todo: validar que sea un numero
                if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 0)
                {
                    filtro = "IdCuenta=" + FiltroTextBox.Text;
                }
                
            }
            else if (BuscarPorComboBox.SelectedIndex == 1) //Descripcion
            {

                filtro = "Descripcion like '%" + FiltroTextBox.Text + "%'";
            }

            dt = gasto.Listar("IdGasto,Fecha,IdCuenta,IdSubClas,Concepto,Monto", filtro);

            DataGridView.DataSource = dt;

            CantidadtextBox.Text = DataGridView.RowCount.ToString();
            TotaltextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
        }
    }
}
