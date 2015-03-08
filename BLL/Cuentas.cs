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

       private  float balance;
       public float Balance 
       {
           get { return balance; } 
       }
      
        
        public Cuentas()
        {
            this.IdCuenta = 0;
            this.Descripcion = string.Empty;
            this.balance = 0;
        }

        /// <summary>
        /// Permite insertar una Cuenta en la base de datos
        /// </summary>
        /// <returns>Verdadero o Falso segun sea, insertado o no</returns>
        public Boolean Insertar()
        {
            this.IdCuenta = 0;

            this.IdCuenta = (int)Conexion.ObtenerValorDb("Insert Into Cuentas (Descripcion,Balance)  Values('" + this.Descripcion + "',0) Select @@Identity");

            return this.IdCuenta > 0;

        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Cuentas set Descripcion= '" + this.Descripcion + "' Where IdCuenta = " + this.IdCuenta);

        }


        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Cuentas where IdCuenta=" + IdBuscado);
        }

        public static Boolean AfectarBalance(int IdCuenta,float ValorAumentar)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Cuentas Set Balance=Balance+" + ValorAumentar.ToString() + "Where IdCuenta=" + IdCuenta.ToString() );
       
        }

        public static Boolean DecrementarBalance(int IdCuenta, float ValorDecrementar)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Cuentas set Balance= Balance-" + ValorDecrementar.ToString() + "Where IdCuenta =" + IdCuenta.ToString());
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Descripcion,Balance", "IdCuenta=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;
               
                this.IdCuenta = IdBuscado;
                this.Descripcion = (string)dt.Rows[0]["Descripcion"].ToString();
                this.balance = (float )dt.Rows[0]["Balance"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cuentas where " + Filtro);
        }
    }
}
