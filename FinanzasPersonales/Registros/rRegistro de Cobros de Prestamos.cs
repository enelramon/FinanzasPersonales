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
    public partial class rRegistro_de_Cobros_de_Prestamos : Form
    {
        public rRegistro_de_Cobros_de_Prestamos()
        {
            InitializeComponent();
            LlenaComboBoxCuentas();
        }

        private void GuardarButtomRegistro_Click(object sender, EventArgs e)
        {
            Cobros regCobPre = new Cobros();

            
            regCobPre.IdPrestamo = Utilitarios.ToInt(comboBox1Prestamo.SelectedValue.ToString());
           ///// regCobPre.Balance = Convert.ToSingle(textBox3Balance.Text);
            regCobPre.Monto = Utilitarios.ToInt(textBox2MontoCB.Text);
            regCobPre.Insertar();
           


        }



        private void LlenaComboBoxCuentas()
        {
            Prestamos cuent = new Prestamos();
            DataTable dt = cuent.Listar();

            comboBox1Prestamo.DataSource = dt;
            comboBox1Prestamo.DisplayMember = "Concepto";
           comboBox1Prestamo.ValueMember = "IdPrestamo";

        }

        private void comboBox1Prestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BorrarButtomRegistro_Click(object sender, EventArgs e)
        {
          //  if (textBox1Registro.Text.Trim().Length == 0)
          //  {
            //    MessageBox.Show("debe especificar el id");
           // }
           // else
           // {

               // MessageBox.Show("Estas seguro de que deseas borrar?", "Confirmacion", MessageBoxButtons.YesNo);
               // Prestamos pre = new Prestamos();
                //pre.Eliminar(Convert.ToInt32(textBox1Registro.Text));

          //  }
        }
    }
}
