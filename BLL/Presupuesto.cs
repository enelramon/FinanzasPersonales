using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class Presupuesto
    {
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb
     
        public int IdPresupuesto { get; set;}

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

       // List<PresupuestoDetalle> detalle = new List<PresupuestoDetalle>();
        

        

       

         public Presupuesto()
        {
            this.IdPresupuesto = 0;
            this.Descripcion = string.Empty;
            this.Fecha = DateTime.Now;
        }



        


         public Boolean Insertar(  )
        {
            
           // string fecha = string.Format("MM / dd / yyyy", Fecha);

            this.IdPresupuesto = 0;
            this.IdPresupuesto = Convert.ToInt32(Conexion.EjecutarDB("Insert Into Presupuesto (Descripcion)  Values('" + this.Descripcion + "') Select @@Identity"));
            return this.IdPresupuesto > 0;
            

           

           
            

        }


        public Boolean Modificar(string Descripcion)
        {
            return Conexion.EjecutarDB("Update Presupuesto set Descripcion= '" + Descripcion + "' Where IdPresupuesto = " + this.IdPresupuesto);

        }


        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Presupuesto where IdPresupuesto=" + IdBuscado);
        }

       

        public  Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("*", "IdPresupuesto = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;
                DataRow[] dr ;
                dr = dt.Select("IdPresupuesto = " + IdBuscado);
                this.IdPresupuesto = IdBuscado;
                this.Descripcion = (string)dr[0]["Descripcion"];
                
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Presupuesto where " + Filtro);
        }



        //Agrega un detalle a la Lista  detalle 
        public int Add(int IdPresupuesto ,int IdClasificacion, int Valor)
        {
           
            PresupuestoDetalle pd = new PresupuestoDetalle(IdClasificacion, Valor);
           if (Buscar(IdPresupuesto)) 
           {
                if (pd.Valor > 0) 
                { 
                    detalle.Add(pd);
                   return pd.Guardar(IdPresupuesto);
                }
           }

           return 0;      
        }


	

    } //end clase 
}
