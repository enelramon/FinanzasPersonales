using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
   public class CobrosPrestamos
    {
         private ConexionDb Conexion = new ConexionDb();

        public int IdPrestamo { set; get; }
        public int IdCobro { get; set; }
        public float Monto{set; get;}
        
        
        public CobrosPrestamos()
        {
            this.IdPrestamo=0;
            this.IdCobro=0; 
            this.Monto=0;
           
        }

        public Boolean Insertar()
        {   
            return Conexion.EjecutarDB("Insert Into CobrosPrestamos (IdCobro,IdPrestamo,Monto)  Values('" +this.IdCobro + "','" + this.IdPrestamo + "','" +this.Monto+ "') Select @@Identity");
        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update CobrosPrestamos set = '" + this.IdCobro + "' Where IdCobro = " + this.IdPrestamo);

        }
    

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from CobrosPrestamos where IdCobro=" + IdBuscado);
        }



        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable(); 

            dt = this.Listar("Monto", "IdPrestamo,IdCobro=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;
               
                this.IdPrestamo = IdBuscado;
                this.IdCobro=IdBuscado;
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
