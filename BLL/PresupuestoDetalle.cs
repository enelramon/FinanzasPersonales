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
    public class PresupuestoDetalle
    {
        public int Valor { get; set; }
        public int IdClasificacion { get; set; }

        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb

        // para el funcionamiento de la clase hace falta el metodo buscar de clasficaciones
        //que no esta static por eso la instanciacion de Clasificaciones
        Clasificaciones c = new Clasificaciones();

        public PresupuestoDetalle ()
        {
            Valor = 0;
            IdClasificacion = 0;
        }



        public PresupuestoDetalle( int IdClasificacion, int Valor)
        {
            if (Valor > 0 && c.Buscar(IdClasificacion) )
            {
                this.Valor = Valor;
                this.IdClasificacion = IdClasificacion;
            }                
        }

        public int Guardar(int IdPresupuesto = 0) 
        {
            int paso = 0;
          
            paso = Convert.ToInt32(Conexion.ObtenerValorDb("Insert Into PresupuestoDetalle (IdPresupuesto, IdClasificacion, Valor)  Values(" + IdPresupuesto + ", " + IdClasificacion + ", " + Valor + ")Select @@IDENTITY"));
            
            return paso ;
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from PresupuestoDetalle where Secuencia=" + IdBuscado);
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from PresupuestoDetalle where " + Filtro);
        }


    }//end class
}
