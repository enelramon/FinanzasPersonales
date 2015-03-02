using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
   public class Presupuesto
    {

       
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb

        public int IdPresupuesto { get; set; }

        public string Descripcion { get; set; }
       
        public DateTime Fecha { get; set; }


       //test

        public Presupuesto()
        {
            this.IdPresupuesto = 0;
            this.Descripcion = string.Empty;
            this.Fecha = DateTime.Now;
        }

        /// <summary>
        /// Permite insertar una Presupuesto en la base de datos
        /// </summary>
        /// <returns>Verdadero o Falso segun sea, insertado o no</returns>
        public Boolean Insertar()
        {
            this.IdPresupuesto = 0;

            this.IdPresupuesto = (int)Conexion.ObtenerValorDb("Insert Into Presupuesto (Descripcion, Fecha)  Values('" + this.Descripcion+"', "+this.Fecha +") Select @@Identity");

            return this.IdPresupuesto > 0;

        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Presupuesto set Descripcion= '" + this.Descripcion + "',Fecha='"+this.Fecha.ToString()+" Where IdPresupuesto = " + this.IdPresupuesto);

        }
    

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Presupuesto where IdPresupuesto=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            
            DataTable dt = new DataTable();

            dt = Conexion.BuscarDb("Select Descripcion, Fecha From Presupuesto Where IdPresupuesto=" + IdBuscado );

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdPresupuesto = IdBuscado;
                this.Descripcion = (string)dt.Rows[0]["Descripcion"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cuentas where " + Filtro);
        }
    }
}
