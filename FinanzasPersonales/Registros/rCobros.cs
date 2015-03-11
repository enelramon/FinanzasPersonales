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
    public partial class rCobros : Form
    {
        Cobros Cobro = new Cobros();

        public rCobros()
        {
            InitializeComponent();
        }

        private void rCobros_Load(object sender, EventArgs e)
        {
            Prestamos Prest = new Prestamos();
            if (Prest.Listar().Rows.Count > 0)
            {
                PrestamoComboBox.DataSource = Prest.Listar();
                PrestamoComboBox.ValueMember = "IdPrestamo";
                PrestamoComboBox.DisplayMember = "Concepto";
            }
            else
            {
                MessageBox.Show("No existen Cuentas por cobrar.");
                this.Close();
            }
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdTextBox.Clear();
            MontoTextBox.Clear();
            BalanceTextBox.Clear();
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdTextBox.Text) && Utilitarios.ToInt(IdTextBox.Text) > 0)
            {
                Cobro.Eliminar(Utilitarios.ToInt(IdTextBox.Text));
                MessageBox.Show("Cobro Eliminado Con Exito");
            }
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            Cobro.IdCobro = Utilitarios.ToInt(IdTextBox.Text);
            Cobro.IdPrestamo = Utilitarios.ToInt(PrestamoComboBox.SelectedValue.ToString());
            Cobro.Monto = Convert.ToSingle(MontoTextBox.Text);
           

            if (Cobro.IdCobro == 0)
            {
                paso = Cobro.Insertar();
            }
            else
            {
                MessageBox.Show("Por el momento no puedes modificar un Cobro");
            }

            if (paso)
            {
                MessageBox.Show("Prestamo Realizado con Exito");
            }

            else
            {
                MessageBox.Show("Error en el Prestamo");
            }
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {

        }
      }
    }

