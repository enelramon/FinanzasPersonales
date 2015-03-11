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
    public class CobroPrestamo
    {
        ConexionDb Conexion = new ConexionDb();
        public int IdCobro{ get; set; }
        public int IdPrestamo { get; set; }
        public float Monto { get; set; }

        public CobroPrestamo()  
        {
            IdCobro = 0;
            IdPrestamo = 0;
            Monto = 0;    
        }

        public bool Insertar()
        {
            this.IdCobro = Convert.ToInt32(Conexion.ObtenerValorDb("Insert into CobrosPrestamos (  IdPrestamo,Monto) values(" +this.IdPrestamo+  ", " + this.Monto + ")Select @@Identity"));
            return IdCobro > 0;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from CobrosPrestamos where " + Filtro);
        }

        public bool Buscar(int IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("*", "IdCobro = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;
                DataRow[] dr;
                dr = dt.Select("IdPrestamo = " + IdBuscado);
                this.IdPrestamo = IdBuscado;
                this.Monto = (float)dr[0]["Monto"];

            }

            return Encontro;
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from CobrosPrestamos where IdCobro=" + IdBuscado);
        }
    }
}
