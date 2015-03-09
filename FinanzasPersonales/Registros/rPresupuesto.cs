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
    public partial class rPresupuesto : Form
    {
        private Presupuesto p = new Presupuesto();
        Clasificaciones c = new Clasificaciones();
        public rPresupuesto()
        {
            InitializeComponent();
        }

      

        private void rPresupuesto_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            

            ClasificacioncomboBox.DataSource = c.Listar("IdClasificacion,Descripcion", "1=1");

            ClasificacioncomboBox.ValueMember = "IdClasificacion";
            ClasificacioncomboBox.DisplayMember = "Descripcion";
            
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {


            if (Utilitarios.ToInt(ValortextBox.Text) > 0 && Utilitarios.ToInt(IdtextBox.Text) > 0) 
            {
               int x = p.Add(Utilitarios.ToInt(IdtextBox.Text),(int)ClasificacioncomboBox.SelectedValue, Utilitarios.ToInt(ValortextBox.Text));
                string[] row = {x.ToString(), ClasificacioncomboBox.Text  , ValortextBox.Text };
                DetalledataGridView.Rows.Add(row);
                ValortextBox.Clear();

               

          
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DescripciontextBox.Text)) 
            {
                p.Descripcion = DescripciontextBox.Text;
                p.Insertar();
                IdtextBox.Clear();
                IdtextBox.AppendText(p.IdPresupuesto.ToString());
            }
                

        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(IdtextBox.Text) && Utilitarios.ToInt(IdtextBox.Text)  > 0)
            {
                if (p.Buscar(Utilitarios.ToInt(IdtextBox.Text))) { 
                    PresupuestoDetalle pd = new PresupuestoDetalle();
                    Clasificaciones c = new Clasificaciones();
                    p.Buscar(Utilitarios.ToInt(IdtextBox.Text));
                    DescripciontextBox.Clear();
                    DescripciontextBox.AppendText(p.Descripcion);               
                    ActualizarDataGrid(Utilitarios.ToInt(IdtextBox.Text));
                }
                
            }
        }

        private void LimpiarButtom_Click(object sender, EventArgs e)
        {
            IdtextBox.Clear();
            DescripciontextBox.Clear();
            ValortextBox.Clear();
            DetalledataGridView.Rows.Clear();
        }

        private void BorrarButtom_Click(object sender, EventArgs e)
        {
            if (this.DetalledataGridView.Rows.Count > 0) 
            { 
                PresupuestoDetalle pd = new PresupuestoDetalle();
                pd.Eliminar(Convert.ToInt32(DetalledataGridView.CurrentRow.Cells["Secuencia"].Value));
                DetalledataGridView.Rows.RemoveAt(this.DetalledataGridView.SelectedRows[0].Index);
            }
                

            
            
        }

        private void ActualizarDataGrid(int IdPresupuesto) 
        {
            PresupuestoDetalle pd = new PresupuestoDetalle();
            Clasificaciones c = new Clasificaciones();

           DetalledataGridView.Rows.Clear();
            foreach (DataRow dr in pd.Listar("*", "IdPresupuesto = " +IdPresupuesto).Rows)
            {

                c.Buscar((int)dr["IdClasificacion"]);
                DetalledataGridView.Rows.Add(dr["Secuencia"], c.Descripcion, dr["Valor"]);
            }

        }
       
    }
}
