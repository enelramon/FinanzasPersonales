using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Ingresos
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdIngreso{ get; set; }

        public string Fecha { get; set; }

        public int IdCuenta { get; set; }

        public int IdSubClas { get; set; }

        public string Concepto { get; set; }

        public float Valor { get; set; }



        public Ingresos()
        {
            this.IdIngreso= 0;
            this.Fecha = string.Empty;
            this.IdCuenta = 0;
            this.IdSubClas = 0;
            this.Concepto = string.Empty;
            this.Valor = 0;
            
        }

        public Boolean Insertar()
        {
            bool paso = false;
            string va;
            va = String.Format("'{0}',{1},{2},'{3}',{4}", Fecha, IdCuenta, IdSubClas, Concepto, Valor);

            this.IdIngreso = (int) Conexion.ObtenerValorDb("Insert Into Ingresos (Fecha, IdCuenta, IdSubClas, Concepto, Valor)  Values('" + va + "') Select @@Identity");
         
            paso =this.IdIngreso > 0;

            if (paso)
            {
                Cuentas.AfectarBalance(this.IdCuenta,this.Valor );
            }

            return paso;
        }


        public Boolean Modificar()
        {
            Boolean paso = false;
            float Inicial = 0;

            Inicial = (float)Conexion.ObtenerValorDb("Select Valor from Ingresos Where idIngreso=" + this.IdIngreso.ToString());

            paso= Conexion.EjecutarDB("update Ingresos set Fecha= '" + this.Fecha + "', Concepto='"+this.Concepto+"',Valor="+this.Valor+" where idIngreso="+ this.IdIngreso);
             
            if (paso)
            {
                Cuentas.AfectarBalance(this.IdCuenta, Inicial - this.Valor);
            }

            return paso;


        }

        public Boolean Borrar()
        {
            return Conexion.EjecutarDB("delete from Ingresos  where id="+ this.IdIngreso);
            
        }  

        public Boolean Buscar()
        {
            DataTable dt = Conexion.BuscarDb("select * from Cuentas where Descripcion='"+ this.Descripcion+"'");
           // dt = Listar("*", "Descripcion='" + this.Descripcion + "'");

            //if dt.rows.count > 0 
           //this.Descripcion =dt.rows[0]["Descripcion"];
            if (dt.Rows.Count > 0) {
               
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.IdCuenta =(int) dt.Rows[0]["IdCuenta"];
                this.IdSubClas =(int) dt.Rows[0]["IdSubClas"];
                this.Concepto = dt.Rows[0]["Concepto"].ToString();
                this.Valor =(float) dt.Rows[0]["Valor"];

                return true;
         
            }
            return false;
        }

        public DataTable Listar(string campos ="*", string Filtro="1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Ingresos where " + Filtro);
        }
    }
}
