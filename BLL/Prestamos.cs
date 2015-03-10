using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class Prestamos
    {
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb

        public int IdPrestamo { get; set; }
        public int IdCuenta{ get; set; }
        public string Concepto { get; set; }
        public float Monto { get; set; }
        public float Balance {get; set; }


        public Prestamos()
        {
            Cuentas ct = new Cuentas();
            this.IdPrestamo = 0;
            this.IdCuenta = 0;
            this.Concepto = string.Empty;
            this.Monto = 0;
            this.Balance = ct.Balance;
        }

        public Boolean Insertar()
        {
            bool paso2 = false;

            this.IdPrestamo = Convert.ToInt32(Conexion.ObtenerValorDb("Insert Into Prestamos(IdCuenta, Concepto, Monto, Balance)  Values(" + this.IdCuenta + ",'" + this.Concepto + "'," + this.Monto +","+ this.Balance + ") Select @@Identity"));

            paso2 = this.IdPrestamo > 0;

            if (paso2)
            {
                Cuentas.DecrementarBalance(this.IdCuenta, this.Monto);
            }

            return paso2;
        }

        
        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Prestamos where IdPrestamo=" + IdBuscado);
        }


        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Cuenta,Concepto,Monto,Balance", "IdPrestamo=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdPrestamo = IdBuscado;
                this.IdCuenta = Convert.ToInt32(dt.Rows[0]["Cuenta"].ToString());
                this.Concepto = dt.Rows[0]["Concepto"].ToString();
                this.Monto = Convert.ToInt32(dt.Rows[0]["Monto"].ToString());
                this.Balance = Convert.ToInt32(dt.Rows[0]["Balance"].ToString());
            }

            return Encontro;
        }

        public static Boolean DecrementarBalance(int IdPrestamo, float ValorDecrementar)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Prestamos set Balance = Balance -" + ValorDecrementar.ToString() + "Where IdPrestamo =" + IdPrestamo.ToString());

        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Prestamos where " + Filtro);
        }
        
    }
}
