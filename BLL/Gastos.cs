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
    public class Gastos
    {
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb

        public int IdGasto { get; set; }
        public string Concepto { get; set; }
        public int IdCuenta { get; set; }
        public int IdSubClas { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }



        public Gastos()
        {
            this.IdGasto = 0;
            this.Concepto = string.Empty;
            this.IdCuenta = 0;
            this.IdSubClas = 0;
            this.Fecha = DateTime.Now;
            this.Monto = 0;
        }

        //Copia del Esqueleto de Ingresos
        //Faltan algunas modificaciones de lugar
        //Para que este adaptado al 100% a Gastos

        /// <summary>
        /// Inserta un valor a la DB
        /// </summary>
        /// <returns>Retorna si se ingreso o no.</returns>
        public Boolean Insertar()
        {
            bool paso = false;
            
            this.IdGasto = (int)Conexion.ObtenerValorDb("Insert Into Gastos (Fecha, IdCuenta, IdSubClas, Concepto, Monto)  Values('" + this.Fecha + this.IdCuenta + IdSubClas +
                this.Concepto + this.Monto +"') Select @@Identity");

            paso = this.IdGasto > 0;

            if (paso)
            {
                Cuentas.AfectarBalance(this.IdCuenta, this.Monto);
            }

            return paso;
        } 

        public Boolean Modificar()
        {
            Boolean paso = false;
            float Inicial = 0;

            Inicial = Convert.ToSingle(Conexion.ObtenerValorDb("Select Monto from Gastos Where IdGasto=" + this.IdGasto.ToString()));

            paso = Conexion.EjecutarDB("Update Gastos set Fecha = '" + this.Fecha + "', Concepto ='" + this.Concepto +
                "',Monto=" + this.Monto + " where IdGasto=" + this.IdGasto);

            if (paso)
            {
                Cuentas.DecrementarBalance(this.IdCuenta, Inicial + this.Monto);
            }

            return paso;


        }


        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Gastos where IdGasto=" + IdBuscado);
        }


        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Concepto", "IdCuenta=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                //this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.IdCuenta = (int)dt.Rows[0]["IdCuenta"];
                this.IdSubClas = (int)dt.Rows[0]["IdSubClas"];
                this.Concepto = dt.Rows[0]["Concepto"].ToString();
                this.Monto = (float)dt.Rows[0]["Valor"];

            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Gastos where " + Filtro);
        }

    }
}
