using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasPersonales
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void clasificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rClasificaciones clasi = new Registros.rClasificaciones();
            clasi.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tFinanzas Personales\n\tProgramacion Aplicada I inc.\n\tIntegrantes:\n\n\tEnel Almonte\n\tChristopher Genao\n\tJoel Olvares\n\tNewlin Duarte\n\tYahaida Vargas\n\tAngel Rodriguez\n\tFelix Fernandez\n\tKlainer Morales");
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rCuentas rCuenta = new Registros.rCuentas();
            rCuenta.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rGastos gastos = new Registros.rGastos();
            gastos.Show();
        }

        private void cuentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cCuentas cCuenta = new Consultas.cCuentas();
            cCuenta.Show();
        }


        
        private void transferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rTransferencias trans = new Registros.rTransferencias();
            trans.Show();
        }

        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rPresupuesto pres = new Registros.rPresupuesto();
            pres.Show();
        }

      

        private void transferenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cTransferencias ctran = new Consultas.cTransferencias();
            ctran.Show();
        }

        private void gastosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cGastos cGasto = new Consultas.cGastos();
            cGasto.Show();
        }

         private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {

           Registros.rIngresos Ingre= new Registros.rIngresos();
           Ingre.Show();
        }

         private void ingresosToolStripMenuItem1_Click(object sender, EventArgs e)
         {
             Consultas.cIngresos cons = new Consultas.cIngresos();
             cons.Show();
         }

        private void presupuestoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cPresupuesto cPres = new Consultas.cPresupuesto();
            cPres.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rRegistro_de_prestamos reg = new Registros.rRegistro_de_prestamos();
            reg.Show();
        }

        private void clasificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rRegistro_de_Cobros_de_Prestamos cob = new Registros.rRegistro_de_Cobros_de_Prestamos();
            cob.Show();
        }

       
    }
}
