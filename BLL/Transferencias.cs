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
   public  class Transferencias   // creamos la clase Tranferencias
    {
        private ConexionDb Conexion = new ConexionDb();  // instanciamos la Conexion Db

        public int IdTransferencias { get; set;}

        public DateTime Fecha { get; set;}

        public string Concepto { get; set; }
        
        public int IdCuentaOrigen { get; set; }

        public int Valor { get; set; }

         public Transferencias()
        {
            this.IdTransferencias = 0;
            this.Fecha = DateTime.Now;
            this.Concepto = string.Empty;
            this.IdCuentaOrigen = 0;
            this.Valor = 0;
        }

       /// <summary>
       /// permite insertar Transferencias a la Base de Datos
       /// </summary>
      /// <returns>Verdadero o Falso segun sea, insertado o no </returns>

       public Boolean Insertar()
         {
             this.IdTransferencias = 0;
           string datos;

           datos = String.Format("'{0}',{1},'{2}'",this.Fecha.ToString(),this.Concepto,this.IdCuentaOrigen);

           this.IdTransferencias = (int)Conexion.ObtenerValorDb("Insert Into Transferencias (Fecha,Concepto,IdCuentaOrigen)   Values(" + datos + ") Select @@Identity");
             return this.IdTransferencias > 0;
         }

       public Boolean Modificar()
       {
           return Conexion.EjecutarDB("Update Transferencias set Fecha  = '" + this.Fecha + "', Concepto = '" + this.Concepto + "', Valor = "+this.Valor+"  Where IdTransferecia  = " + this.IdTransferencias);
       }

       public Boolean Eliminar(Int32 IdBuscando)
       {
           return Conexion.EjecutarDB("Delete from Transferencias where IdTransferencias=" + IdBuscando);
       }

       public Boolean Buscar(Int32 IdBuscando)
       {
           bool Encontro = false;
           DataTable dt = new DataTable();
           
           dt = Conexion.BuscarDb("Select * Descripcion From Transferencias Where IdTransferencias=" + IdBuscando);

           if (dt.Rows.Count > 0)
           {
               Encontro = true;

               this.IdTransferencias = IdBuscando;
               this.Fecha = (DateTime) dt.Rows[0]["Fecha"];
               this.Concepto = (string) dt.Rows[0]["Concepto"];
               this.Valor = (int) dt.Rows[0]["Valor"];
           }

           return Encontro;
       }

       public DataTable Listar(string campos = "*", string Filtro = "1=1")
       {
           return Conexion.BuscarDb("Select " + campos + " from Transferencias where " + Filtro);
       }
    }
}
