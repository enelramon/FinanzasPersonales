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
        /// Permite insertar una Cuenta en la base de datos
        /// </summary>
        /// <returns>Verdadero o Falso segun sea, insertado o no</returns>
        public Boolean Insertar()
        {
            this.IdCuenta = 0;

            this.IdCuenta = (int)Conexion.ObtenerValorDb("Insert Into Cuentas (Descripcion)  Values('" + this.Descripcion + "') Select @@Identity");

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

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Descripcion", "IdCuenta=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdCuenta = IdBuscado;
                this.Descripcion = (string)dt.Rows[0]["Descripcion"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cuentas where " + Filtro);
        }
    }
}
