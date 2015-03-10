using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
  public  class Prestamos
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdPrestamo { set; get; }
        public int Cuenta { get; set; }
        public string Concepto{set; get;}
        public float Monto{set; get;}
        public float Balance{set; get;}
        
        public Prestamos()
        {
            this.IdPrestamo=0;
            this.Cuenta=0;
            this.Concepto=string.Empty;
            this.Monto=0;
            this.Balance=0;
        }

        public Boolean Insertar()
        {   
            return Conexion.EjecutarDB("Insert Into Prestamos (IdPrestamo,Cuenta,Concepto,Monto,Balance)  Values('" +this.IdPrestamo + "','" + this.Cuenta + "','" +this.Concepto+ "','" +this.Monto+ "','" +this.Balance+ "') Select @@Identity");
        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Prestamos set = '" + this.Concepto + "' Where IdPrestamo = " + this.IdPrestamo);

        }
    

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Prestamos where IdPrestamo=" + IdBuscado);
        }



        public static Boolean AfectarBalance(int IdPrestamo,float ValorAumentar)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Prestamos Set Balance=Balance+" + ValorAumentar.ToString() + "Where IdPrestamo=" + IdPrestamo.ToString());
       
        }    
        
        
        public static Boolean DecrementarBalance(int IdPrestamo, float ValorDecrementar)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Prestamos set Balance= Balance-" + ValorDecrementar.ToString() + "Where IdPrestamo =" + IdPrestamo.ToString());
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
                this.Concepto = (string)dt.Rows[0]["Concepto"].ToString();
                this.Balance = (float )dt.Rows[0]["Balance"];
                this.Cuenta=(int)dt.Rows[0]["Cuenta"];
                this.Monto=(float)dt.Rows[0]["Monto"];
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cuentas where " + Filtro);
        }
    }
}

