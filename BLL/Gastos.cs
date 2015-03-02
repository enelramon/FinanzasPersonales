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
    public class Gastos //Creamos la clase Gastos
    {
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb

        public int IdGastos { get; set; }

        public string Concepto { get; set; }

        public DateTime Fecha { get; set; }

        public int IdCuenta { get; set; }

        public int IdSubClas { get; set; }
        
        public int Monto { get; set; }

        /*
         IdGasto int IDENTITY(1,1) Primary Key,
            Fecha Datetime,
            IdCuenta int references Cuentas(IdCuenta),
            IdSubClas int references SubClasificaciones(IdSubClas),
            Concepto varchar(80),
            Monto floa
         
         */


        public Gastos()
        {
            this.IdGastos = 0;
            this.Fecha = DateTime.Now;
            this.Concepto = string.Empty;
            this.IdCuenta = 0;
            this.IdSubClas = 0;
            this.Monto = 0;
        }

        /// <summary>
        /// Permite insertar Gastos en la base de datos
        /// </summary>
        /// <returns>Verdadero o Falso segun sea, insertado o no</returns>
        public Boolean Insertar()
        {
            this.IdGastos = 0;
            string datos = String.Format("'{0}',{1},{2},{0}",this.Concepto,this.IdCuenta,this.IdSubClas,this.Monto);
            this.IdGastos = (int)Conexion.ObtenerValorDb("Insert Into Gastos (Concepto, IdCuentas, IdSubClas, Monto)  Values(" + datos+ ") Select @@Identity");

            return this.IdGastos > 0;

        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Gastos set Concepto = '" + this.Concepto + "', Fecha = "+ this.Fecha +" , Monto = " + this.Monto + "  Where IdGasto = " + this.IdGastos);

        }


        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Gastos where IdGastos=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = Conexion.BuscarDb("Select *  From Cuentas Where IdGasto=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdCuenta = IdBuscado;
                this.Concepto = (string)dt.Rows[0]["Concepto"];
                this.IdSubClas = (int)dt.Rows[0]["IdSubClas"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Gastos where " + Filtro);
        }
    }
}
