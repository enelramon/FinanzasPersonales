using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    class Cobros
    {

        private ConexionDb Conexion = new ConexionDb();

        public int IdCobro { get; set; }

        public int IdPrestamo { get; set; }

        public int Monto { get; set; }


        public Cobros()
        {
            this.IdCobro = 0;

            this.IdPrestamo = 0;

            this.Monto = 0;

        }

        public Boolean Insertar()
        {
            this.IdCobro = 0;

            this.IdCobro = (int)Conexion.ObtenerValorDb("Insert Into Cobros (Monto)  Values('" + this.Monto + "') Select @@Identity");

            return this.IdCobro> 0;

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Cuentas where IdCobro=" + IdBuscado);
        }


        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Monto", "IdCobro=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdCobro = IdBuscado;
                this.IdPrestamo = (int)dt.Rows[0]["IdPrestamo"];
                this.Monto = (int)dt.Rows[0]["Monto"];
               
            }

            return Encontro;
        }
        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cobros where " + Filtro);
        }

    }
}
