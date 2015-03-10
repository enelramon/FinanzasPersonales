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
    public partial class rPrestamos : Form
    {
        private Prestamos Prestamo = new Prestamos();

        public rPrestamos()
        {
            InitializeComponent();
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Boolean paso = false;

            Prestamo.IdPrestamo = Utilitarios.ToInt(IdTextBox.Text);
            Prestamo.IdCuenta = Utilitarios.ToInt(BuscarPorcomboBox.SelectedValue.ToString());
            Prestamo.Concepto = ConceptoTextBox.Text;
            Prestamo.Monto = Convert.ToSingle(MontoTextBox.Text);
           // Prestamo.Balance = Convert.ToSingle(BalanceTextBox.Text);

            if (Prestamo.IdPrestamo == 0)
            {
                paso = Prestamo.Insertar();
            }
            else
            {
                MessageBox.Show("Por favor no ingrese ningun valor en el ID PRESTAMO");
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


        private void CuentaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void rPrestamos_Load_1(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();

            BuscarPorcomboBox.DataSource = cuenta.Listar("IdCuenta,Descripcion", "1=1");
            BuscarPorcomboBox.ValueMember = "IdCuenta";
            BuscarPorcomboBox.DisplayMember = "Descripcion";
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            ErrorProvider EP = new ErrorProvider();
            Utilitarios.ValidarTextBoxVacio(IdTextBox, EP, "Por favor asigne un ID a eliminar.");
            if (!string.IsNullOrWhiteSpace(IdTextBox.Text) && Utilitarios.ToInt(IdTextBox.Text) > 0)
            {
                Prestamo.Eliminar(Utilitarios.ToInt(IdTextBox.Text));
                MessageBox.Show("Felicidades, Prestamo Eliminado Con Exito!! No Debe!!");
            }
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdTextBox.Clear();
            ConceptoTextBox.Clear();
            MontoTextBox.Clear();
            BalanceTextBox.Clear();
        }
    }
}
