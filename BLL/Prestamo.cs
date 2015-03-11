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
    public class Prestamo
    {
        ConexionDb Conexion = new ConexionDb();
        public int IdPrestamo { get; set; }
        public int IdCuenta { get; set; }
        public string Concepto { get; set; }
        public float Monto { get; set; }
        public float Balance { get; set; }

        public Prestamo() 
        {
            IdPrestamo = 0;
            
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
        }

        public bool Insertar( ) 
        {
            this.IdPrestamo = Convert.ToInt32(Conexion.ObtenerValorDb("Insert into Prestamos (IdCuenta, Concepto, Monto, Balance) values("+this.IdCuenta+", '"+this.Concepto+"', "+this.Monto +", "+Balance+")Select @@Identity"));
            return IdPrestamo > 0;
        }

        public Boolean Modificar(float Balance)
        {
            return Conexion.EjecutarDB("Update Prestamos set Balance= " + Balance + " Where IdPrestamo = " + this.IdPrestamo);

        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Prestamos where " + Filtro);
        }

        public bool Buscar(int IdBuscado) 
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("*", "IdPrestamo = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;
                DataRow[] dr;
                dr = dt.Select("IdPrestamo = " + IdBuscado);
                this.IdPrestamo = IdBuscado;
                this.Concepto = (string)dr[0]["Concepto"];
                this.Monto = Convert.ToSingle(dr[0]["Monto"]);
                this.Balance = Convert.ToSingle(dr[0]["Balance"]);
            }

            return Encontro;
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Prestamos where IdPrestamo=" + IdBuscado);
        }

    }//end class
}
