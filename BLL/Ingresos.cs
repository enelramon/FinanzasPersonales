using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class Ingresos
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdIngreso { get; set; }

        public string Fecha { get; set; }

        public int IdCuenta { get; set; }

        public int IdSubClas { get; set; }

        public string Concepto { get; set; }

        public float Valor { get; set; }



        public Ingresos()
        {
            this.IdIngreso = 0;
            this.Fecha = string.Empty;
            this.IdCuenta = 0;
            this.IdSubClas = 0;
            this.Concepto = string.Empty;
            this.Valor = 0;

        }

        public Boolean Insertar()
        {

            this.IdIngreso = 0;

            string va;
            va = String.Format("'{0}',{1},{2},'{3}',{4}", Fecha, IdCuenta, IdSubClas, Concepto, Valor);
            this.IdIngreso = (int)Conexion.ObtenerValorDb("Insert Into Ingresos (Fecha, IdCuenta, IdSubClas, Concepto, Valor)  Values('" + va + "')Select @@Identity");

            return this.IdIngreso > 0;

        }


        public Boolean Modificar()
        {

            return Conexion.EjecutarDB("update Ingresos set Fecha= '" + this.Fecha + "', Concepto='" + this.Concepto + "',Valor=" + this.Valor + " where IdIngreso=" + this.IdIngreso);


        }

        public Boolean Borrar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("delete from Ingresos  where IdIngreso=" + IdBuscado);

        }


        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Fecha", "IdIngreso=" + IdBuscado);

            //if dt.rows.count > 0 
            //this.Descripcion =dt.rows[0]["Descripcion"];
            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdIngreso = (int)dt.Rows[0]["IdIngreso"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.IdCuenta = (int)dt.Rows[0]["IdCuenta"];
                this.IdSubClas = (int)dt.Rows[0]["IdSubClas"];
                this.Concepto = dt.Rows[0]["Concepto"].ToString();
                this.Valor = (float)dt.Rows[0]["Valor"];

                return true;

            }
            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Ingresos where " + Filtro);
        }
    }
}


