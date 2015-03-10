using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasPersonales.Registros
{
    public partial class Registros_de_Prestamos : Form
    {
        public Registros_de_Prestamos()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = DialogResult.Ignore;

            if (Utilitarios.ToInt(IdprestamostextBox.Text) == 0)
            {
                Consultas.cGastos Cuentas = new Consultas.cGastos();

                result = Cuentas.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IdprestamostextBox.Text = Cuentas.DatoEncontrado.ToString();
                }
                else
                {
                    IdprestamostextBox.Clear();
                }
            }


            if (Cuentas.Buscar(Utilitarios.ToInt(IdprestamostextBox.Text)))
            {

                IdprestamostextBox.Text = Cuentas.IdCuentas.ToString();
                conceptoTextBox.Text =Cuentas.Concepto;
                
            }
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdprestamostextBox.Clear();
            conceptoTextBox.Text = string.Empty;
            conceptoTextBox.Text = "";
            textBox2pendiente.Clear();
            textBox1monto.Clear();
           
        }

        private void combcuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
