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
    public class Cuentas //Creamos la clase cuentas
    {
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb

        public int IdCuenta { get; set; }

        public string Descripcion { get; set; }



        public Cuentas()
        {
            this.IdCuenta = 0;
            this.Descripcion = string.Empty;
        }
        /// <summary>
        /// Permite insertar una cuenta en la base de datos
        /// </summary>
        /// <returns>Verdadero o Falso, Segun sea, insertado o no</returns>
        public Boolean Insertar()
        {
            this.IdCuenta = 0;
            this.IdCuenta = (int)Conexion.ObtenerValorDb("Insert Into Cuentas (Descripcion)  Values ('" + this.Descripcion + "') Select @@Identity");
            return this.IdCuenta > 0;
                
        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Cuentas set Descripcion='" + this.Descripcion + "' where Descripcion='" + this.Descripcion + "'");
        }

        public Boolean Borrar()
        {
            return Conexion.EjecutarDB("Delete from Cuentas where Descripcion='"+this.Descripcion+"'");
        }

        public Boolean Buscar()
        {
            //if dt.rows.count > 0 
            //this.Descripcion =dt.rows[0]["Descripcion"];
            return false;
        }
        
        public DataTable Listar(string campos ="*", string Filtro="1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cuentas where " + Filtro);
        }
    }
}
