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
            MessageBox.Show("\tFinanzas Personales\n\tProgramacion Aplicada I inc.\n\tIntegrantes:\n\n\tEnel Almonte\n\tChristopher Genao\n\tJoel Olvares\n\tNewlin Duarte\n\tYahaida Vargas\n\tAngel Rodriguez\n\tFeliz Radel\n\tKlainer Morales");
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rCuentas rCuenta = new Registros.rCuentas();
            rCuenta.Show();
        }

       
    }
}
