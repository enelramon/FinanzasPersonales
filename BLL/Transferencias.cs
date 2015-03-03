using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

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
            this.IdTransferencia = 0;

            this.IdTransferencia = Convert.ToInt32(Conexion.ObtenerValorDb("Insert Into Transferencias (Concepto, IdCuentaOrigen, IdCuentaDestino, Valor, Fecha)  Values('" + this.Concepto + "','" + this.IdCuentaOrigen + "','" + this.IdCuentaDestino + "'," + this.Valor + ", GETDATE() ) Select @@Identity"));
            
            Cuentas.AfectarBalance(this.IdCuentaDestino, this.Valor);
            
            return this.IdTransferencia > 0;
        }


        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Transferencias set Valor = '" + this.Valor + "' Where IdTransferencia = " + this.IdTransferencia);

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Transferencias where IdTransferencia =" + IdBuscado);
        }

    }
}
