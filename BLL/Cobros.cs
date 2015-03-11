﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class Cobros
    {
        private ConexionDb Conexion = new ConexionDb(); // Creando la conexion a la DB.

        public int IdCobro { get; set; }
        public int IdPrestamo { get; set; }
        public float Monto { get; set; }


        public Cobros()
        {
            this.IdCobro = 0;
            this.IdPrestamo = 0;
            this.Monto = 0;
        }

        public Boolean Insertar() // Metodo INSERT
        {
            Prestamos Pres1 = new Prestamos();
            bool paso = false;
            this.IdCobro = Convert.ToInt32(Conexion.ObtenerValorDb("Insert Into CobrosPrestamos (IdPrestamo, Monto)  Values(" + this.IdPrestamo + "," + this.Monto + ") Select @@Identity"));
            paso = this.IdCobro > 0;

            if (paso)
            {
                Prestamos.AfectarBalance(this.IdPrestamo, this.Monto);
            }
            
            return paso;
        }

        public Boolean Eliminar(Int32 IdBuscado)  // Metodo DELETE
        {
            return Conexion.EjecutarDB("Delete from CobrosPrestamos where IdCobro =" + IdBuscado);
        }

    
    
    
    }
}