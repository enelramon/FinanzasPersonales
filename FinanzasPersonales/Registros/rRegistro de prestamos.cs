using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasPersonales.Registros
{
    public partial class rRegistro_de_prestamos : Form
    {
        public rRegistro_de_prestamos()
        {
            InitializeComponent();
        }

        private void LimpiarButtomRegistro_Click(object sender, EventArgs e)
        {
            textBox1Registro.Clear();
            textBox2Registro.Clear();
            textBox3Registro.Clear();
            textBox4Resgistro.Clear();
        }
    }
}
