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
    public partial class rIngresos : Form
    {
         private Ingresos Ingreso = new Ingresos();

        public rIngresos()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Consultas.cIngresos consu = new Consultas.cIngresos();
            consu.Show();
        }


        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            textBox2IdIngreso.Clear();
            textBox2Concepto.Clear();
            textBox1.Clear();
            
         
        }
        private void GuardarButtom_Click(object sender, EventArgs e)
        {


            Boolean paso = false;

             ErrorProvider EP = new ErrorProvider();

             Utilitarios.ValidarTextBoxVacio(textBox2Concepto, EP, "Debe introducir algun concepto");

            ErrorProvider EP1= new ErrorProvider();
           if(textBox1.Text.Trim().Length==0){
           EP1.SetError(textBox1, "Debe introducir Algun Concepto.");
            
            }
           ErrorProvider EP2= new ErrorProvider();
           if (textBox2Concepto.Text.Trim().Length > 70) { 
           EP2.SetError(textBox2Concepto,"no puede tener mas de 70 letras");
            
           }
           Ingresos i= new Ingresos();

           i.IdIngreso = Utilitarios.ToInt(textBox2IdIngreso.Text);
           i.Fecha = dateTimePicker1Ingreso.Value;
           i.Concepto = textBox2Concepto.Text;
           i.Valor = Utilitarios.ToInt(textBox1.Text);
           

           if (Ingreso.IdIngreso > 0)
           {
               paso = Ingreso.Modificar();
               MessageBox.Show("modificar");
           }
           else
           {
               paso = Ingreso.Insertar();
               MessageBox.Show("insertar");
           
           }

             if (paso)
                MessageBox.Show("Registro Guardado");
            else
                MessageBox.Show("Por Favor Complete los Campo");
        }

        private void textBox2Concepto_TextChanged(object sender, EventArgs e)
        {

        }
/*
        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            if (Ingreso.Eliminar(Utilitarios.ToInt(textBox2IdIngreso.Text)))
                MessageBox.Show("Registro Guardado");
        }
*/
        }
       
    }

