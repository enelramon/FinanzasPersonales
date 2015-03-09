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

        public Boolean Insertar()
        {
            bool paso2 = false;

            //todo: Terminar esto.
            this.IdGasto = Convert.ToInt32(Conexion.ObtenerValorDb("Insert Into Gastos (Concepto, IdCuenta, IdSubclas, Fecha, Monto)  Values('" + this.Concepto + "'," + this.IdCuenta + "," + this.IdSubClas +", GETDATE()," + this.Monto +") Select @@Identity"));

            paso2 = this.IdGasto > 0;
            
            if(paso2)
            {

                Cuentas.AfectarBalance(this.IdCuenta, this.Monto);
            }

            return paso2;
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
                Cuentas.DecrementarBalance(this.IdCuenta, Inicial - this.Monto);
            }

            return paso;//End Modificar


        }


        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Gastos where IdGasto=" + IdBuscado);
        }


        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Concepto", "IdGasto=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                //this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.IdGasto = IdBuscado;
                this.Concepto = dt.Rows[0]["Concepto"].ToString();
                this.Monto = Convert.ToInt32(dt.Rows[0]["Monto"].ToString());
                
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Gastos where " + Filtro);
        }


            public static DataTable GetSubClas()
        {
            ConexionDb Conexion = new ConexionDb();
            return Conexion.BuscarDb("Select * from SubClasificaciones");
        }

    }
}
