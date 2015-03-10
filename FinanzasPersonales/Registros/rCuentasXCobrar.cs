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
    public partial class rCuentasXCobrar : Form
    {
        private Prestamos Prestamos = new Prestamos();

        public rCuentasXCobrar()
        {
            InitializeComponent();
        }

        private void rCuentasXCobrar_Load(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();

            CuentaComboBox.DataSource = cuenta.Listar("IdCuenta,Descripcion", "1=1");
            CuentaComboBox.ValueMember = "IdCuenta";
            CuentaComboBox.DisplayMember = "Descripcion";
 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdPrestamoTextBox.Clear();
            MontoTextBox.Clear();
            ConceptoTextBox.Clear();
            BalancePTextBox3.Clear();
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
        Boolean paso = false;

            if (!Utilitarios.ValidarTextBoxVacio(ConceptoTextBox, errorProvider1, "Debe introducir algun Concepto"))
                return;

            if (MontoTextBox.Text.Trim().Length == 0)
            {
               errorProvider3.SetError(MontoTextBox, "Debe introducir Algun Concepto.");
               MontoTextBox.Focus();
                return;
           }
            
            if (ConceptoTextBox.Text.Trim().Length == 0 || ConceptoTextBox.Text.Trim().Length > 80)
            {
                errorProvider2.SetError(ConceptoTextBox, "Los caracteres no pueden exeder a 80");
                ConceptoTextBox.Focus();
            return;
        }
            Prestamos.IdPrestamo = Utilitarios.ToInt(IdPrestamoTextBox.Text);
            Prestamos.IdCuenta = Utilitarios.ToInt(CuentaComboBox.SelectedValue.ToString());
            Prestamos.Concepto = ConceptoTextBox.Text;
            Prestamos.Monto = Convert.ToInt32(MontoTextBox.Text);
            
            if (Prestamos.IdPrestamo > 0) {
                //Editando
                IdPrestamoTextBox.Clear();
                MontoTextBox.Clear();
                ConceptoTextBox.Clear();
                BalancePTextBox3.Clear();

                MessageBox.Show("Enel Dijo que no queria que se Modificara");
            }
            else {
                //Insertando
                paso = Prestamos.Insertar();
            }

            if (paso)
                MessageBox.Show("Registro Guardado");
            else
                MessageBox.Show("Por Favor Complete los Campo");
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            {
                if (IdPrestamoTextBox.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(IdPrestamoTextBox, "Debe ingresar un ID");
                    IdPrestamoTextBox.Focus();
                    return;
                }
                if (Prestamos.Eliminar(Utilitarios.ToInt(IdPrestamoTextBox.Text)))
                    MessageBox.Show("Registro Borrado");

            }
        }

        private void IdPrestamoTextBox_TextChanged(object sender, EventArgs e)
        {

        }    


        }
    }
