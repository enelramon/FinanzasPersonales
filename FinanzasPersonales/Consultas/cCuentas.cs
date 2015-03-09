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
    public partial class cCuentas : Form
    {
        private int datoEncontrado;

        public int DatoEncontrado
        {
            get { return datoEncontrado; }
        }

        public cCuentas()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorcomboBox.SelectedIndex == 0)//IdCuenta
            {
                //todo: validar que sea un numero
                filtro = "IdCuenta=" + FiltrotextBox.Text;
            }
            else if (BuscarPorcomboBox.SelectedIndex == 1)//Descripcion
            {

                filtro = "Descripcion like '%" + FiltrotextBox.Text + "%'";
            }

            dt = cuenta.Listar("IdCuenta,Descripcion,Balance", filtro);

            DatosdataGridView.DataSource = dt;

            CantidadtextBox.Text = DatosdataGridView.RowCount.ToString();
            TotaltextBox.Text = dt.Compute("Sum(Balance)", "1=1").ToString();
        }

        private void AceptarButtom_Click(object sender, EventArgs e)
        {
            int index;

            index = DatosdataGridView.CurrentRow.Index;

            datoEncontrado = (int)DatosdataGridView.CurrentRow.Cells["IdCuenta"].Value;


            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void CancelarButtom_Click(object sender, EventArgs e)
        {
            datoEncontrado = 0;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DatosdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FiltrotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TotaltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BuscarPorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
