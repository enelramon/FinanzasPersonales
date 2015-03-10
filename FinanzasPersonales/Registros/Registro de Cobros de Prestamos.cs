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
    public partial class Registro_de_Cobros_de_Prestamos : Form
    {
        public Registro_de_Cobros_de_Prestamos()
        {
            InitializeComponent();
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdCobrosBox.Clear();
            textBox2BPendiente.Clear();
            texmonto.Clear();
        }

        private void comboBox1cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
