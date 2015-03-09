using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace FinanzasPersonales.Registros
{
    public partial class rClasificaciones : Form
    {
        Clasificaciones clasificacion = new Clasificaciones();

        public rClasificaciones()
        {
            InitializeComponent();
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            NombreTextBox.Clear();
            IDTextBox.Clear();

        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            if (!Utilitarios.ValidarTextBoxVacio(NombreTextBox, errorProvider1, "Debe introducir alguna descripción"))
                return;

            clasificacion.IdClasificacion = Utilitarios.ToInt(IDTextBox.Text);
            clasificacion.Descripcion = NombreTextBox.Text;

            if (clasificacion.IdClasificacion > 0)
            {
                
                paso = clasificacion.Modificar();
            }
            else
            {
               
                paso = clasificacion.Insertar();

            }

            if (paso)
                MessageBox.Show("Registro Guardado");
                NombreTextBox.Clear();
                IDTextBox.Clear();
            
        }
        


        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            if (!Utilitarios.ValidarTextBoxVacio(IDTextBox, errorProvider2, "Debe introducir alguna descripción"))
                return;

            if (clasificacion.Eliminar(Utilitarios.ToInt(IDTextBox.Text)))
                MessageBox.Show("Registro Borrado");
                NombreTextBox.Clear();
                IDTextBox.Clear();

        }


        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = DialogResult.Ignore;

            if (Utilitarios.ToInt(IDTextBox.Text) == 0)
            {
                Consultas.cClasificacion cClasificacion = new Consultas.cClasificacion();

                result = cClasificacion.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IDTextBox.Text = cClasificacion.DatoEncontrado.ToString();
                }
                else
                {
                    IDTextBox.Clear();
                }

                if (clasificacion.Buscar(Utilitarios.ToInt(IDTextBox.Text)))
                {
                    IDTextBox.Text = clasificacion.IdClasificacion.ToString();
                    NombreTextBox.Text = clasificacion.Descripcion;

                }

            }
        }
    }
}
