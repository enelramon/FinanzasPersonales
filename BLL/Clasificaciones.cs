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
    public class Clasificaciones
    {
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb
        
        public int IdClasificacion { get; set; }

        public string Nombre { get; set; }

        public Clasificaciones()
        {
            this.IdClasificacion = 0;
            this.Nombre = string.Empty;
        }

        public Boolean Insertar()
        {


            return Conexion.EjecutarDB("Insert Into Clasificaciones (Nombre)  Values('" + this.Nombre + "')");

        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Clasificaciones set Nombre='" + this.Nombre + "' where Nombre='" + this.Nombre + "'");
        }

        public Boolean Borrar()
        {
            return Conexion.EjecutarDB("Delete from Clasificaciones where Nombre='"+this.Nombre+"'");
        }

        public Boolean Buscar()
        {
            //if dt.rows.count > 0 
            //this.Descripcion =dt.rows[0]["Descripcion"];
            return false;
        }
        
        public DataTable Listar(string campos ="*", string Filtro="1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Clasificaciones where " + Filtro);
        }
    }
}
