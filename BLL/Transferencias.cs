using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

//TODO: Arreglar que se inserte el valor en la base de datos. (Sale 0) y Validar Todo!!

namespace BLL
{
    public class Transferencias
    {
        private ConexionDb Conexion = new ConexionDb();

        // Creando setters y getters:
        public int IdTransferencia { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCuentaOrigen { get; set; }
        public int IdCuentaDestino { get; set; }
        public string Concepto { get; set; }
        public float Valor { get; set; }

        public Transferencias()
        {
            this.IdTransferencia = 0;
            this.IdCuentaOrigen = 0;
            this.IdCuentaDestino = 0;
            this.Concepto = string.Empty;
            this.Valor = 0;
            this.Fecha = DateTime.Now;
        }


        public Boolean Insertar()
        {
            bool paso2 = false;

            this.IdTransferencia = Convert.ToInt32(Conexion.ObtenerValorDb("Insert Into Transferencias (Concepto, IdCuentaOrigen, IdCuentaDestino, Valor, Fecha)  Values('" + this.Concepto + "'," + this.IdCuentaOrigen + "," + this.IdCuentaDestino +"," + this.Valor +", GETDATE()) Select @@Identity"));

            paso2 = this.IdTransferencia > 0;
            
            if(paso2)
            {

                Cuentas.DecrementarBalance(this.IdCuentaOrigen, this.Valor);
                Cuentas.AfectarBalance(this.IdCuentaDestino, this.Valor);
            }

            return paso2;
        }


        public Boolean Modificar()
        {
            bool paso1 = false;

            paso1 = Conexion.EjecutarDB("Update Transferencias set Valor = "+ this.Valor +" Where IdTransferencia = "+ this.IdTransferencia);

            if (paso1)
            {
                Cuentas.DecrementarBalance(this.IdTransferencia, this.Valor);
            }

            return paso1;

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Transferencias where IdTransferencia =" + IdBuscado);
        }


        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Fecha", "IdTransferencia=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdTransferencia = (int)dt.Rows[0]["Id Transferencia"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.IdCuentaOrigen = (int)dt.Rows[0]["Id Cuenta Origen"];
                this.IdCuentaDestino = (int)dt.Rows[0]["Id Cuenta Destino"];
                this.Concepto = dt.Rows[0]["Concepto"].ToString();
                this.Valor = (float)dt.Rows[0]["Valor"];

                return true;

            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Transferencias where " + Filtro);
        }

    }
}
