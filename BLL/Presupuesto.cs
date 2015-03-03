using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    class Presupuesto
    {
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb
     
        public int IdPresupuesto { get; set;}

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        List<PresupuestoDetalle> detalle = new List<PresupuestoDetalle>();
        

        

       

         public Presupuesto()
        {
            this.IdPresupuesto = 0;
            this.Descripcion = string.Empty;
        }



        // copia del esqueleto inicial de Cuentas que todavia no esta adaptado totalmente para Presupuesto


         public Boolean Insertar()
        {
            this.IdPresupuesto = 0;

            this.IdPresupuesto = (int)Conexion.ObtenerValorDb("Insert Into Presupuesto (Descripcion)  Values('" + this.Descripcion + "') Select @@Identity");

            return this.IdPresupuesto > 0;

        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Presupuesto set Descripcion= '" + this.Descripcion + "' Where IdPresupuesto = " + this.IdPresupuesto);

        }


        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Presupuesto where IdPresupuesto=" + IdBuscado);
        }

       

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Descripcion", "IdPresupuesto=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdPresupuesto = IdBuscado;
                this.Descripcion = (string)dt.Rows[0]["Descripcion"];
                
               
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Presupuesto where " + Filtro);
        }



        //Agrega un detalle a la Tabla Presupuesto detalle con el Id del presupuesto que se esta trabajando actualmente
        public bool Add(int Valor, int IdClasificacion)
        {

            return Conexion.EjecutarDB("Insert Into PresupuestoDetalle (IdPresupuesto, IdClasificacion, Valor)  Values(" + this.IdPresupuesto + " , " + IdClasificacion + " , " + Valor + ") ");
              
        }


	

    } //end clase 
}
