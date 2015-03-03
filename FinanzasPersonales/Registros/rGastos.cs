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

            if (!Utilitarios.ValidarTextBoxVacio(ConceptoTextBox, errorProvider1, "Debe introducir alguna descripción"))
                return;

            //if (DescripciontextBox.Text.Trim().Length ==0)
            //{
            //    errorProvider1.SetError(DescripciontextBox, "Debe introducir alguna descripción");
            //    MessageBox.Show("Debe introducir alguna descripción");
            //    DescripciontextBox.Focus();
            //    return;
            //}


            Gastos.IdGasto = Utilitarios.ToInt(IDTextBox.Text);
            Gastos.Concepto = ConceptoTextBox.Text;

            if (Gastos.IdGasto > 0)
            {
                //editando
                paso = Gastos.Modificar();
            }
            else
            {
                //Insertando
                paso = Gastos.Insertar();

            }

            if (paso)
                MessageBox.Show("Registro Guardado");
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IDTextBox.Clear();
            CuentaTextBox.Clear();
            SubClasTextBox.Clear();
            ConceptoTextBox.Clear();
            MontoTextBox.Clear();
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            {
                if (Gastos.Eliminar(Utilitarios.ToInt(IDTextBox.Text)))
                    MessageBox.Show("Registro Borrado");

            }
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {

        }

        private void rGastos_Load(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();

            BuscarPorcomboBox.DataSource = cuenta.Listar("IdCuenta,Descripcion", "1=1");

            BuscarPorcomboBox.ValueMember = "IdCuenta";
            BuscarPorcomboBox.DisplayMember = "Descripcion";
            
        }
    }
}
