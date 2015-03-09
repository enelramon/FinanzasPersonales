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
   public class SubClasificaciones
    {
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb

        public int IdSubClasificaciones { get; set; }
        public int IdClasificaciones { get; set; }
        public string Descripcion { get; set; }


       public SubClasificaciones()
        {
            this.IdSubClasificaciones = 0;
            this.IdClasificaciones = 0;
            this.Descripcion = string.Empty;
        }

       /// <summary>
       /// //permite insercar las subclasificaiones a la base de datos
       /// </summary>
       /// <returns>// retorna verdadero o falso segun sea insertado</returns>

       public Boolean Insertar()
        {
            this.IdSubClasificaciones = 0;

            this.IdSubClasificaciones = (int)Conexion.ObtenerValorDb("Insert Into SubClasificaciones (IdSubClasificaciones,IdClasificaciones,Descripcion)  Values("+this.IdSubClasificaciones+""+this.IdClasificaciones+"'" + this.Descripcion + "') Select @@Identity");

            return this.IdSubClasificaciones > 0;

        }

       public Boolean Modificar()
       {
           return Conexion.EjecutarDB("Update SubClasificaciones set Descripcion= '" + this.Descripcion + "' Where IdSubclasificaciones = " + this.IdSubClasificaciones);

       }

       public Boolean Eliminar(Int32 IdBuscado)
       {
           return Conexion.EjecutarDB("Delete from SubClasificaciones where IdSubClasificaciones=" + IdBuscado);
       }

       public Boolean Buscar(Int32 IdBuscado)
       {
           bool Encontro = false;
           DataTable dt = new DataTable();

           dt = this.Listar("IdSubClasificaciones", "Descripcion=" + IdBuscado);

           if (dt.Rows.Count > 0)
           {
               Encontro = true;

               this.IdSubClasificaciones = IdBuscado;
               this.IdClasificaciones = (int)dt.Rows[0]["IdClasificaciones"];
               this.Descripcion = (string)dt.Rows[0]["Descripcion"];
           }

           return Encontro;
       }

       public DataTable Listar(string campos = "*", string Filtro = "1=1")
       {
           return Conexion.BuscarDb("Select " + campos + " from SubClasificaciones where " + Filtro);
       }


    }
}
