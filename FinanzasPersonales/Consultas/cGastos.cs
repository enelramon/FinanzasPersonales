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
            switch (BuscarPorComboBox.SelectedIndex)
            {

                case 0:
                    if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10){
                            filtro = "IdGasto=" + FiltroTextBox.Text;
                            dt = gasto.Listar("IdGasto,Fecha,IdCuenta,IdSubClas,Concepto,Monto", filtro);
                            DataGridView.DataSource = dt;

                        CantidadtextBox.Text = DataGridView.RowCount.ToString();
                        TotaltextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                       }
                    else 
                        MessageBox.Show("Por Favor Llene la Casilla.");
                        break;


                case 1:
                    if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10)
                    {
                        filtro = "IdCuenta=" + FiltroTextBox.Text;
                        DataGridView.DataSource = dt;

                        CantidadtextBox.Text = DataGridView.RowCount.ToString();
                        TotaltextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                        else
                        MessageBox.Show("Por Favor Llene la Casilla2");
                    break;
                case 2:
                   if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 10)
                    {
                        filtro = "IdSubClas=" + FiltroTextBox.Text;
                        DataGridView.DataSource = dt;

                        CantidadtextBox.Text = DataGridView.RowCount.ToString();
                        TotaltextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                        else
                        MessageBox.Show("Por Favor Llene la Casilla3");
                    break;
                case 3:
                    if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 80)
                    {
                        filtro = "Concepto like '%" + FiltroTextBox.Text + "%'";
                        DataGridView.DataSource = dt;

                        CantidadtextBox.Text = DataGridView.RowCount.ToString();
                        TotaltextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                    else
                        MessageBox.Show("Por Favor Llene la Casilla4");
                    break;
                case 4:
                    if (FiltroTextBox.Text.Length > 0 && FiltroTextBox.Text.Length < 80)
                    {
                        filtro = "Monto>=" + FiltroTextBox.Text;
                        DataGridView.DataSource = dt;

                        CantidadtextBox.Text = DataGridView.RowCount.ToString();
                        TotaltextBox.Text = dt.Compute("Sum(Monto)", "1=1").ToString();
                    }
                   else
                        MessageBox.Show("Por Favor Llene la Casilla5");
                    break;

                default:
                    break;

                 }
            }
        

        private void AceptarButtom_Click(object sender, EventArgs e)
        {
            Registros.rGastos gastos = new Registros.rGastos();
            int index;

            index = DataGridView.CurrentRow.Index;

            datoEncontrado = (int)DataGridView.CurrentRow.Cells["IdGasto"].Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelarButtom_Click(object sender, EventArgs e)
        {
            datoEncontrado = 0;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
