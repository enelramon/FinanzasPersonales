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
    public partial class cTransferencias : Form
    {
        private int datoEncontrado;

        public int DatoEncontrado
        {
            get { return datoEncontrado; }
        }

        public cTransferencias()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Transferencias trans = new Transferencias();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorComboBox.SelectedIndex == 0)// IdTransferencia
            {
                //todo: validar que sea un numero

                filtro = "IdTransferencia=" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 1)// IdCuentaOrigen
            {

                filtro = "IdCuentaOrigen =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 2)// IdCuentaDestino
            {

                filtro = "IdCuentaDestino =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 3)// Concepto
            {

                filtro = "Concepto like '%" + FiltroTextBox.Text + "%'";
            }

            else if (BuscarPorComboBox.SelectedIndex == 4)// Fecha
            {

                filtro = "Fecha =" + FiltroTextBox.Text;
            }

            else if (BuscarPorComboBox.SelectedIndex == 5)// Valor
            {

                filtro = "Valor =" + FiltroTextBox.Text;
            }


            dt = trans.Listar("IdTransferencia, IdCuentaOrigen, IdCuentaDestino, Concepto, Fecha, Valor", filtro);

            TransferenciasDataGridView1.DataSource = dt;

            CantidadTextBox.Text = TransferenciasDataGridView1.RowCount.ToString();
            TotalTextBox.Text = dt.Compute("Sum(Valor)", "1=1").ToString();
        }

        private void CancelarButtom_Click(object sender, EventArgs e)
        {
        
            datoEncontrado = 0;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        
        }

        private void AceptarButtom_Click(object sender, EventArgs e)
        {

        }

    }
}
