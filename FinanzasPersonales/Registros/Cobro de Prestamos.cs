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
    public partial class Cobro_de_Prestamos : Form
    {
        ErrorProvider err = new ErrorProvider();
        public Cobro_de_Prestamos()
        {
            InitializeComponent();
        }

        private void Cobro_de_Prestamos_Load(object sender, EventArgs e)
        {
            Prestamo p = new Prestamo();
            if (p.Listar().Rows.Count > 0)
            {
                PrestamoComboBox.DataSource = p.Listar();
                PrestamoComboBox.ValueMember = "IdPrestamo";
                PrestamoComboBox.DisplayMember = "Concepto";
            }
            else 
            {
                MessageBox.Show("No hay Cuentas por cobrar.");
                this.Close();
            }
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdCobrotextBox.Clear();
            MontotextBox.Clear();
            BalancetextBox.Clear();
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Prestamo p = new Prestamo();
            Cuentas c = new Cuentas();
            CobroPrestamo cobro = new CobroPrestamo();
            if ( Utilitarios.ValidarTextBoxVacio(MontotextBox, err, "Por favor llene este campo")) 
            {
               
              
                
                p.Buscar((int)PrestamoComboBox.SelectedValue);
                        if(p.Balance >= Utilitarios.ToInt(MontotextBox.Text))
                        {
                            cobro.IdPrestamo = p.IdPrestamo;
                            cobro.Monto = Utilitarios.ToInt(MontotextBox.Text);
                            cobro.Insertar();
                            p.Modificar(p.Balance - Utilitarios.ToInt(MontotextBox.Text));                                
                        }
                        else
                        {
                            MessageBox.Show("El monto es invalido...");
                        }
                }
            //}
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            if(Utilitarios.ValidarTextBoxVacio(IdCobrotextBox, err, "Por favor llene este campo."))
            {
                CobroPrestamo cobro = new CobroPrestamo();
                cobro.Eliminar(Utilitarios.ToInt(IdCobrotextBox.Text));
            }
        }

    }
}
