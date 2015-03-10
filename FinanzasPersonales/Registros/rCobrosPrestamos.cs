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

namespace FinanzasPersonales.Registros
{
    public partial class rCobrosPrestamos : Form
    {
        CobrosPrestamos cobrosPrestamos = new CobrosPrestamos();

        public rCobrosPrestamos()
        {
            InitializeComponent();
        }

        private void CobrosPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            cobrosPrestamos.IdCobro = Utilitarios.ToInt(IdCobrotextBox.Text);
            cobrosPrestamos.Monto = Utilitarios.ToInt(MontotextBox.Text);
            cobrosPrestamos.IdPrestamo = Utilitarios.ToInt(IdPrestamotextBox.Text);

            if (cobrosPrestamos.IdCobro > 0)
            {

                paso = cobrosPrestamos.Modificar();
            }
            else
            {

                paso = cobrosPrestamos.Insertar();


            }

            if (paso)
                MessageBox.Show("Registro Guardado");
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            if (cobrosPrestamos.Eliminar(Utilitarios.ToInt(IdCobrotextBox.Text)))
                MessageBox.Show("Registro Borrado");
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdCobrotextBox.Clear();
            IdPrestamotextBox.Clear();
            MontotextBox.Clear();

        }
    }
}
