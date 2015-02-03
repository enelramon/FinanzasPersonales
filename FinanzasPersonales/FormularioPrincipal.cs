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

       
    }
}
