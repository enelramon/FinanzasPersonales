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
    public class CobroPrestamos
    {
        private ConexionDb Conexion = new ConexionDb(); //instanciamos la ConexionDb

        public int IdCobro { get; set; }
        public int IdPrestamo { get; set; }
        public float Monto { get; set; }
        

        public CobroPrestamos()
        {
            this.IdPrestamo = 0;
            this.Monto = 0;
        }

        public Boolean Insertar()
        {
            bool paso2 = false;

            this.IdPrestamo = Convert.ToInt32(Conexion.ObtenerValorDb("Insert Into CobroPrestamos(IdPrestamo,Monto)  Values("+this.Monto + "," + this.IdPrestamo + ") Select @@Identity"));

            paso2 = this.IdPrestamo > 0;

            if (paso2)
            {

                Prestamos.DecrementarBalance(this.IdPrestamo, this.Monto);
            }

            return paso2;
        }


        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from CobroPrestamos where IdCobro=" + IdBuscado);
        }


        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("*", "IdCobro = " + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;
                DataRow[] dr;
                dr = dt.Select("IdCobro = " + IdBuscado);
                this.IdCobro = IdBuscado;
                this.Monto = Convert.ToInt32(dt.Rows[0]["Monto"].ToString());
                
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from CobroPrestamos where " + Filtro);
        }
    }
}
