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
            Transferencia.Valor = Utilitarios.ToInt(ValorTextBox.Text);

            ErrorProvider EP = new ErrorProvider();
           bool ValidConcept = Utilitarios.ValidarTextBoxVacio(ConceptoTextBox, EP, "Por favor asigne un Concepto.");

            ErrorProvider EP2 = new ErrorProvider();
           bool ValidCuentaOrigen = Utilitarios.ValidarTextBoxVacio(IdCuentaOrigenTextBox, EP2, "Por favor asigne una Cuenta de Origen.");

            ErrorProvider EP3 = new ErrorProvider();
           bool ValidCuentaDestino = Utilitarios.ValidarTextBoxVacio(IdCuentaDestinoTextBox, EP3, "Por favor asigne una Cuenta de Destino.");

            ErrorProvider EP4 = new ErrorProvider();
           bool ValidValor = Utilitarios.ValidarTextBoxVacio(ValorTextBox, EP4, "Por favor asigne un .");

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

            //todo: Revisar esta validacion
            if (paso && (ValidConcept = true) && (ValidCuentaOrigen = true) && (ValidCuentaDestino = true) && (ValidValor = true))
                MessageBox.Show("Transferencia Guardada");
            else
                MessageBox.Show("Error en la transferencia.");
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdTransferenciaTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdTransferenciaTextBox.Text) && Utilitarios.ToInt(IdTransferenciaTextBox.Text) > 0)
            {
                Transferencia.Eliminar(Utilitarios.ToInt(IdTransferenciaTextBox.Text));
                MessageBox.Show("Registro Eliminado Con Exito");
            }
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Consultas.cTransferencias cTran = new Consultas.cTransferencias();
            cTran.Show();
        }

        private void IdCuentaOrigenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdTransferenciaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
