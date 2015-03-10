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
        ErrorProvider err = new ErrorProvider();
        public rPrestamos()
        {
            InitializeComponent();
        }

        private void rPrestamos_Load(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();
            CuentacomboBox.DataSource = cuenta.Listar();
            CuentacomboBox.ValueMember = "IdCuenta";
            CuentacomboBox.DisplayMember = "Descripcion";
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            
            Prestamo p = new Prestamo();
            if(Utilitarios.ValidarTextBoxVacio(IdPrestamotextBox,err , "Por favor introduzca un dato."))            
            {
                if(p.Buscar(Utilitarios.ToInt(IdPrestamotextBox.Text)))
                {
                    CuentacomboBox.SelectedValue = Utilitarios.ToInt(IdPrestamotextBox.Text);
                    ConceptotextBox.Clear();
                    ConceptotextBox.AppendText(p.Concepto);
                    MontotextBox.Clear();
                    MontotextBox.AppendText(p.Monto.ToString());
                    BalancetextBox.Clear();
                    BalancetextBox.AppendText(p.Balance.ToString());
                }
            }
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdPrestamotextBox.Clear();
            ConceptotextBox.Clear();
            MontotextBox.Clear();
            BalancetextBox.Clear();
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            
            Prestamo p = new Prestamo();
            if (Utilitarios.ValidarTextBoxVacio(IdPrestamotextBox, err, "Por favor introduzca un dato.") && Utilitarios.ValidarTextBoxVacio(ConceptotextBox, err, "Por favor introduzca un dato.") && Utilitarios.ValidarTextBoxVacio(MontotextBox, err, "Por favor introduzca un dato.") && Utilitarios.ToInt(MontotextBox.Text)> 0) 
            {
                
                p.IdCuenta = (int)CuentacomboBox.SelectedValue;
                p.Concepto = ConceptotextBox.Text;
                p.Monto = Utilitarios.ToInt(MontotextBox.Text);                
                p.Insertar();
                Cuentas.DecrementarBalance((int)CuentacomboBox.SelectedValue, p.Monto);

            }    

        }

        private void BorrarButtom_Click(object sender, EventArgs e)           
        {
            Prestamo p = new Prestamo();
            if (Utilitarios.ValidarTextBoxVacio(IdPrestamotextBox, err, "Por favor introduzca un dato."))
            {
                if (p.Buscar(Utilitarios.ToInt(IdPrestamotextBox.Text)))
                {
                    p.Eliminar(Utilitarios.ToInt(IdPrestamotextBox.Text));
                }
            }
        }

    }// end class

}
