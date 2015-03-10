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
    public partial class rGastos : Form
    {
        private Gastos Gastos = new Gastos();

        public rGastos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            if (!Utilitarios.ValidarTextBoxVacio(ConceptoTextBox, ErrorProvider1, "Debe introducir alguna descripción"))
                return;

            if (MontoTextBox.Text.Trim().Length == 0)
            {
               ErrorProvider3.SetError(MontoTextBox, "Debe introducir Algun Concepto.");
               MontoTextBox.Focus();
                return;
           }
            
            if (ConceptoTextBox.Text.Trim().Length > 80)
            {
                errorProvider4.SetError(ConceptoTextBox, "Los caracteres no pueden exeder a 80");
                ConceptoTextBox.Focus();
            return;
            }
            Gastos.IdGasto = Utilitarios.ToInt(IDTextBox.Text);
            Gastos.Concepto = ConceptoTextBox.Text;
            Gastos.Monto = Convert.ToSingle(MontoTextBox.Text);
            Gastos.IdCuenta = Utilitarios.ToInt(BuscarPorcomboBox.SelectedValue.ToString());
            Gastos.IdSubClas = Utilitarios.ToInt(BuscarPor2comboBox.SelectedValue.ToString());

            if (Gastos.IdGasto > 0) {
                //Editando
                paso = Gastos.Modificar();
            }
            else {
                //Insertando
                paso = Gastos.Insertar();
            }

            if (paso)
                MessageBox.Show("Registro Guardado");
            else
                MessageBox.Show("Por Favor Complete los Campo");
        }

        private void LimpiarButtom_Click(object sender, EventArgs e) {
            IDTextBox.Clear();
            ConceptoTextBox.Clear();
            MontoTextBox.Clear();
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            {
                if (IDTextBox.Text.Trim().Length == 0)
                {
                    ErrorProvider1.SetError(IDTextBox, "Debe ingresar un ID");
                    IDTextBox.Focus();
                    return;
                }
                if (Gastos.Eliminar(Utilitarios.ToInt(IDTextBox.Text)))
                    MessageBox.Show("Registro Borrado");

            }
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = DialogResult.Ignore;

            if (Utilitarios.ToInt(IDTextBox.Text) == 0)
            {
                Consultas.cGastos cGastos = new Consultas.cGastos();

                result = cGastos.ShowDialog();

                if (result == DialogResult.OK)
                {
                    IDTextBox.Text = cGastos.DatoEncontrado.ToString();
                }
                else
                {
                    IDTextBox.Clear();
                }
            }


            if (Gastos.Buscar(Utilitarios.ToInt(IDTextBox.Text)))
            {
                IDTextBox.Text = Gastos.IdGasto.ToString();
                ConceptoTextBox.Text = Gastos.Concepto;
            }

        }

        private void rGastos_Load(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();

            BuscarPorcomboBox.DataSource = cuenta.Listar("IdCuenta,Descripcion", "1=1");
            BuscarPorcomboBox.ValueMember = "IdCuenta";
            BuscarPorcomboBox.DisplayMember = "Descripcion";
            //

            SubClasificaciones SubClas = new SubClasificaciones();

            BuscarPor2comboBox.DataSource = SubClas.Listar("IdSubClas,Descripcion", "1=1");
            BuscarPor2comboBox.ValueMember = "IdSubClas";
            BuscarPor2comboBox.DisplayMember = "Descripcion";
            //*/
        }

        private void BuscarPorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuscarPor2comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
