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
        private ConexionDb Conexion = new ConexionDb();
        public int IdClasificacion { get; set; }
        public string Descripcion { get; set; }

        public Clasificaciones()
        {
            this.IdClasificacion = 0;
            this.Descripcion = string.Empty;
        }

        public Boolean Insert()
        {
            this.IdClasificacion = 0;
            this.IdClasificacion = (int)Conexion.ObtenerValorDb("Insert Into (Descripcion) Values('" + this.Descripcion + "') Select @@Identity");

            return this.IdClasificacion > 0;
        }

        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Cuentas set Descripcion= '" + this.Descripcion + "' Where IdClasificacion = " + this.IdClasificacion);

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("delete from Clasificaciones where IdClasificacion=" + IdBuscado);

        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Descripcion", "IdClasificacion=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;
                this.IdClasificacion = IdBuscado;
                this.Descripcion = (string)dt.Rows[0]["Descripcion"];

            }
            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select" + campos + "from clasificaciones where" + Filtro);

        }

    }
}