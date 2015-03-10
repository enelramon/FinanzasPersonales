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
    public partial class rCobro : Form
    {
        private CobroPrestamos CPrestamo = new CobroPrestamos();

        public rCobro()
        {
            InitializeComponent();
        }

        private void rCobro_Load(object sender, EventArgs e)
        {
            Prestamos pres = new Prestamos();

            PrestamoComboBox.DataSource = pres.Listar("IdPrestamo,Concepto", "Balance > 0");
            PrestamoComboBox.ValueMember = "IdPrestamo";
            PrestamoComboBox.DisplayMember = "Concepto";
          
            }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            if (!Utilitarios.ValidarTextBoxVacio(MontoTextBox, errorProvider1, "Debe introducir Un Monto"))
                return;

            if (MontoTextBox.Text.Trim().Length == 0)
            {
               errorProvider2.SetError(MontoTextBox, "Debe introducir Algun Monto.");
               MontoTextBox.Focus();
                return;
           }
            
        
            CPrestamo.IdCobro = Utilitarios.ToInt(IdCobroTextBox.Text);
            CPrestamo.IdPrestamo = Utilitarios.ToInt(PrestamoComboBox.SelectedValue.ToString());
            CPrestamo.Monto = Convert.ToInt32(MontoTextBox.Text);
            
            if (CPrestamo.IdCobro > 0) {
                //Editando
                IdCobroTextBox.Clear();
                MontoTextBox.Clear();
                BalancePTextBox3.Clear();

                MessageBox.Show("Enel Dijo que no queria que se Modificara");
            }
            else {
                //Insertando
                paso = CPrestamo.Insertar();
            }

            if (paso)
                MessageBox.Show("Registro Guardado");
            }


        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdCobroTextBox.Clear();
            MontoTextBox.Clear();
            BalancePTextBox3.Clear();
        }

    }
}
