using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class PresupuestoDetalle
    {

        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb

        public int IdPresupuesto { get; set; }
        public int IdClasificacion { get; set; }
        public float Valor { get; set; }
      
        public PresupuestoDetalle()
        {
          this.IdPresupuesto = 0;
          this.IdClasificacion = 0;
          this.Valor = 0;
        }
            public Boolean Insertar()
        {
            this.IdPresupuesto = 0;

            this.IdPresupuesto = (int)Conexion.ObtenerValorDb("Insert Into PresupuestoDetalle (IdPresupuesto,IdClaisficacion,Valor )  Values(" + this.IdPresupuesto+", "+ this.IdClasificacion +","+this.Valor+") Select @@Identity");

            return this.IdPresupuesto > 0;

        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update PresupuestoDetalle set = Valor" + this.Valor +" Where IdPresupuesto = " + this.IdPresupuesto);

        }
    

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from PresupuestoDetalle where IdPresupuesto=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            
            DataTable dt = new DataTable();

            dt = Conexion.BuscarDb("Select Valor From PresupuestoDetalle Where IdPresupuesto=" + IdBuscado );

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdPresupuesto = IdBuscado;
                this.Valor = (float)dt.Rows[0]["Valor"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cuentas where " + Filtro);
        }
        
    }
}
