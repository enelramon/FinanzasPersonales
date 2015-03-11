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
    public class Prestamos
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdPrestamo { get; set; }
        public int IdCuenta{ get; set; }
        public string Concepto { get; set; }
        public int Monto { get; set; }
        public float Balance { get; set; }

        public Prestamos()
        {
            
        this.IdPrestamo=0;
        this.IdCuenta=0;
        this.Concepto=String.Empty;
        this.Monto=0;
        this.Balance = 0;
        }

        public Boolean Insertar()
        {
            this.IdPrestamo = 0;

            this.IdPrestamo = (int)Conexion.ObtenerValorDb("Insert Into RegistroDePrestamos (IdCuenta,Concepto,Monto,Balance)  Values("+this.IdCuenta+",'" + this.Concepto + "',"+this.Monto+","+this.Balance+") Select @@Identity");

            return this.IdPrestamo > 0;

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from RegistroDePrestamos where IdPrestamo=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Concepto,Monto,Balance", "IdPrestamo=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdPrestamo=IdBuscado;
                this.IdCuenta=(int)dt.Rows[0]["IdCuenta"];
                this.Concepto=(string)dt.Rows[0]["Concepto"].ToString();
                this.Monto=(int)dt.Rows[0]["Monto"];
                this.Balance = (float)dt.Rows[0]["Balance"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from RegistroDePrestamos where " + Filtro);
        }
    }
}
