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
    public partial class rTransferencias : Form
    {
        Transferencias Transferencia = new Transferencias();

        public rTransferencias()
        {
            InitializeComponent();
        }

        private void rTransferencias_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdTransferenciaTextBox.Clear();
            IdCuentaDestinoTextBox.Clear();
            IdCuentaOrigenTextBox.Clear();
            ConceptoTextBox.Clear();
            ValorTextBox.Clear();
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            Transferencia.IdTransferencia = Utilitarios.ToInt(IdTransferenciaTextBox.Text);
            Transferencia.Concepto = ConceptoTextBox.Text;
            Transferencia.IdCuentaOrigen = Utilitarios.ToInt(IdCuentaOrigenTextBox.Text);
            Transferencia.IdCuentaDestino = Utilitarios.ToInt(IdCuentaDestinoTextBox.Text);
            Transferencia.Valor = Utilitarios.ToInt(IdTransferenciaTextBox.Text);

            if (Transferencia.IdTransferencia > 0)
            {
                //editando
                paso = Transferencia.Modificar();
            }
            else
            {
                //Insertando
                paso = Transferencia.Insertar();

            }

            if (paso)
                MessageBox.Show("Transferencia Guardada");
        }
    }
}
