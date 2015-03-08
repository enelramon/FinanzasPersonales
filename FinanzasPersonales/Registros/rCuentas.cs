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
    public partial class rCuentas : Form
    {
        public rCuentas()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            Cuentas Cuenta = new Cuentas();

            if (Cuenta.Buscar(ToInt(IdCuentatextBox.Text)))
            {
                IdCuentatextBox.Text = Cuenta.IdCuenta.ToString();
                DescripciontextBox.Text = Cuenta.Descripcion;

            }

        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Cuentas Cuenta = new Cuentas();

            Cuenta.IdCuenta = ToInt(IdCuentatextBox.Text);
            Cuenta.Descripcion = DescripciontextBox.Text;

            if (Cuenta.IdCuenta > 0)
            {
                //editando
                Cuenta.Modificar();
            }
            else
            {
                //Insertando
                Cuenta.Insertar();

            }
        }

        private int ToInt(string texto)
        {
            int valor = 0;

            int.TryParse(texto, out valor);

            return valor;
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {

        }



    }
}
