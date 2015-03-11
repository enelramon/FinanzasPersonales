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
    public class Prestamos
    {
        private ConexionDb Conexion = new ConexionDb(); // Creando la conexion a la DB.

        // Creando setters y getters. // Edito

        public int IdPrestamo { get; set; }
        public int IdCuenta { get; set; }
        public String Concepto { get; set; }
        public float Monto { get; set; }
        public float Balance { get; set; }


        public Prestamos()  // Creando el constructor.
        {
            this.IdPrestamo = 0;
            this.IdCuenta = 0;
            this.Concepto = String.Empty;
            this.Monto = 0;
            this.Balance = 0;

        }

        public Boolean Insertar() // METODO INSERT
        {
            bool paso = false;
            this.IdPrestamo = Convert.ToInt32(Conexion.ObtenerValorDb("Insert Into Prestamos (IdCuenta, Concepto, Monto, Balance)  Values(" + this.IdCuenta + ",'" + this.Concepto + "'," + this.Monto + ", " + this.Balance + ") Select @@Identity"));
            paso = this.IdPrestamo > 0;

            if (paso)
            {
                DecrementarBalance(this.IdPrestamo, this.Monto);
            }

            return paso;

        }

        public Boolean Eliminar(Int32 IdBuscado)  // Metodo DELETE
        {
            return Conexion.EjecutarDB("Delete from Prestamos where IdPrestamo =" + IdBuscado);
        }


        public static Boolean AfectarBalance(int IdPrestamo, float ValorAumentar)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Cuentas Set Balance = Balance +" + ValorAumentar.ToString() + "Where IdCuenta =" + IdPrestamo.ToString()); // poner  Prestamo.IdCuenta

        }

        public static Boolean DecrementarBalance(int IdPrestamo, float ValorDecrementar)
        {
            ConexionDb Conexion = new ConexionDb();

            return Conexion.EjecutarDB("Update Cuentas set Balance = Balance-" + ValorDecrementar.ToString() + "Where IdCuenta =" + IdPrestamo.ToString()); // poner  Prestamo.IdCuenta
        }



    }
}