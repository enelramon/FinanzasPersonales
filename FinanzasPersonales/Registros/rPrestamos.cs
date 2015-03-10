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
    public partial class rPrestamos : Form
    {
        Prestamos prestamos = new Prestamos();

        public rPrestamos()
        {
            InitializeComponent();
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            prestamos.IdPrestamo = Utilitarios.ToInt(IdPrestamostextBox.Text);
            prestamos.Concepto =ConceptotextBox.Text;
            prestamos.Monto = Utilitarios.ToInt(MontotextBox.Text);
            prestamos.Balance = Utilitarios.ToInt(BalancePtextBox.Text);


            if (prestamos.IdPrestamo > 0)
            {

                paso = prestamos.Modificar();
            }
            else
            {

                paso = prestamos.Insertar();


            }

            if (paso)
                MessageBox.Show("Registro Guardado");
            }
        


        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            if (prestamos.Eliminar(Utilitarios.ToInt(IdPrestamostextBox.Text)))
                MessageBox.Show("Registro Borrado");
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdPrestamostextBox.Clear();
            ConceptotextBox.Clear();
            MontotextBox.Clear();
            BalancePtextBox.Clear();
        }
    }
}
