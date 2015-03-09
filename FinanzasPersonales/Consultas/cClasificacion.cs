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
    public partial class cClasificacion : Form
    {
        private int datoEncontrado;

        public int DatoEncontrado
        {
            get { return datoEncontrado; }
        }

        public cClasificacion()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Clasificaciones clasificaciones = new Clasificaciones();
            DataTable dt = new DataTable();
            string filtro = "1=1";

            if (BuscarPorcomboBox.SelectedIndex == 0)
            {
                filtro = "IdClasificacion=" + FiltrotextBox.Text;
            }
            else if (BuscarPorcomboBox.SelectedIndex == 1)
            {

                filtro = "Descripcion like '%" + FiltrotextBox.Text + "%'";
            }

            dt = clasificaciones.Listar("IdClasificacion,Descripcion", filtro);

            DatosdataGridView.DataSource = dt;

            CantidadtextBox.Text = DatosdataGridView.RowCount.ToString();
        }

        private void AceptarButtom_Click(object sender, EventArgs e)
        {
            int index;

            index = DatosdataGridView.CurrentRow.Index;
            datoEncontrado = (int)DatosdataGridView.CurrentRow.Cells["IdClasificacion"].Value;

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
