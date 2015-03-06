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
    public partial class rCuentas : Form
    {
        private Cuentas Cuenta = new Cuentas();

        public rCuentas()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = DialogResult.Ignore;

            if (Utilitarios.ToInt(IdCuentatextBox.Text) == 0)
            {
                Consultas.cCuentas cCuenta = new Consultas.cCuentas();

                result = cCuenta.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IdCuentatextBox.Text = cCuenta.DatoEncontrado.ToString();
                }
                else
                {
                    IdCuentatextBox.Clear();
                }
            }


            if (Cuenta.Buscar(Utilitarios.ToInt(IdCuentatextBox.Text)))
            {
                IdCuentatextBox.Text = Cuenta.IdCuenta.ToString();
                DescripciontextBox.Text = Cuenta.Descripcion;

            }

        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            if (!Utilitarios.ValidarTextBoxVacio(DescripciontextBox, errorProvider1, "Debe introducir alguna descripción"))
                return;

            //if (DescripciontextBox.Text.Trim().Length ==0)
            //{
            //    errorProvider1.SetError(DescripciontextBox, "Debe introducir alguna descripción");
            //    MessageBox.Show("Debe introducir alguna descripción");
            //    DescripciontextBox.Focus();
            //    return;
            //}


            Cuenta.IdCuenta = Utilitarios.ToInt(IdCuentatextBox.Text);
            Cuenta.Descripcion = DescripciontextBox.Text;

            if (Cuenta.IdCuenta > 0)
            {
                //editando
                paso = Cuenta.Modificar();
            }
            else
            {
                //Insertando
                paso = Cuenta.Insertar();

            }

            if (paso)
                MessageBox.Show("Registro Guardado");
        }



        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            if (Cuenta.Eliminar(Utilitarios.ToInt(IdCuentatextBox.Text)))
                MessageBox.Show("Registro Guardado");

        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdCuentatextBox.Clear();
            DescripciontextBox.Clear();
        }



    }
}
