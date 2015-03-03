using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class PresupuestoDetalle
    {
        public int IdPresupuesto { get; set; }
        public int IdClasificacion { get; set; }

        

        public PresupuestoDetalle (){
            IdPresupuesto = 0;
            IdClasificacion = 0;
        }

        public PresupuestoDetalle(int IdPresupuesto, int IdClasificacion){
            this.IdPresupuesto = IdPresupuesto;
            this.IdClasificacion = IdClasificacion;
        }


    }
}
