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

namespace FinanzasPersonales.Consultas
{
    public partial class cPresupuesto : Form
    {
        Presupuesto p = new Presupuesto();
        public cPresupuesto()
        {
            InitializeComponent();
        }

        private void BuscarButtom_Click(object sender, EventArgs e)  
        {
            
            if (Convert.ToInt32(IdcomboBox.SelectedValue) > 0)
            {
                if (p.Buscar(Utilitarios.ToInt(IdcomboBox.SelectedValue.ToString())))
                {

                    PresupuestoDetalle pd = new PresupuestoDetalle();
                    Clasificaciones c = new Clasificaciones();
                    p.Buscar(Utilitarios.ToInt(IdcomboBox.SelectedValue.ToString()));
                    DescripciontextBox.Clear();
                    DescripciontextBox.AppendText(p.Descripcion);
                    DetalledataGridView.Rows.Clear();
                    foreach (DataRow dr in pd.Listar("*", "IdPresupuesto = " + Utilitarios.ToInt(IdcomboBox.SelectedValue.ToString())).Rows)
                    {
                        c.Buscar((int)dr["IdClasificacion"]);
                        DetalledataGridView.Rows.Add(dr["Secuencia"], c.Descripcion, dr["Valor"]);
                    }
                }
                
            }
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            Presupuesto p = new Presupuesto();
            if (Utilitarios.ToInt(IdcomboBox.SelectedValue.ToString()) > 0)
            {
                if (p.Buscar(Utilitarios.ToInt(IdcomboBox.SelectedValue.ToString())))
                {
                    p.Modificar(DescripciontextBox.Text);
                }
            }
            
            this.Close();
        }

        private void CancelarButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cPresupuesto_Load(object sender, EventArgs e)
        {
            Presupuesto p = new Presupuesto();
            IdcomboBox.DataSource = p.Listar("IdPresupuesto, Descripcion", "1=1");
            IdcomboBox.ValueMember = "IdPresupuesto";
            IdcomboBox.DisplayMember = "IdPresupuesto";
        }

        private void IdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }//end class
}
