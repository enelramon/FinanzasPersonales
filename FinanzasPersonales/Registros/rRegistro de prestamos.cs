using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace FinanzasPersonales.Registros
{
    public partial class rRegistro_de_prestamos : Form
    {

        private Prestamos Prestamo = new Prestamos();

        public rRegistro_de_prestamos()
        {
            InitializeComponent();
            LlenaComboBoxCuentas();
        }

        private void LimpiarButtomRegistro_Click(object sender, EventArgs e)
        {
            textBox1Registro.Clear();
            textBox2Registro.Clear();
            textBox3Registro.Clear();
            textBox4Resgistro.Clear();
        }

        private void GuardarButtomRegistro_Click(object sender, EventArgs e)
        {
            Prestamos pres = new Prestamos();

            ErrorProvider EP = new ErrorProvider();

            Utilitarios.ValidarTextBoxVacio(textBox2Registro, EP, "Debe introducir algun concepto");

            ErrorProvider EP1 = new ErrorProvider();
            if (textBox3Registro.Text.Trim().Length == 0)
            {
                EP1.SetError(textBox3Registro, "Debe introducir Algun Concepto.");

            }
            ErrorProvider EP2 = new ErrorProvider();
            if (textBox2Registro.Text.Trim().Length > 70)
            {
                EP2.SetError(textBox2Registro, "no puede tener mas de 70 letras");

            }

            pres.IdPrestamo=Utilitarios.ToInt(textBox1Registro.Text);
           pres.IdCuenta =Utilitarios.ToInt(comboBox1Registro.SelectedValue.ToString());
           pres.Concepto = textBox2Registro.Text;
           pres.Monto =Utilitarios.ToInt(textBox3Registro.Text);
           pres.Balance = Convert.ToSingle(textBox3Registro.Text);
           pres.Insertar();

         
        }

        private void LlenaComboBoxCuentas() {
            Cuentas cuent = new Cuentas();
            DataTable dt = cuent.Listar();

            comboBox1Registro.DataSource = dt;
            comboBox1Registro.DisplayMember = "Descripcion";
            comboBox1Registro.ValueMember = "IdCuenta";

        }

        private void BorrarButtomRegistro_Click(object sender, EventArgs e)
        {
            if (textBox1Registro.Text.Trim().Length == 0)
            {
                MessageBox.Show("debe especificar el id");
            }
            else
            {

                if (MessageBox.Show("Estas seguro de que deseas borrar?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Prestamos pre = new Prestamos();
                    pre.Eliminar(Convert.ToInt32(textBox1Registro.Text));
                    MessageBox.Show("se ha eliminado");
                }
            }
        }

       
    }
}
