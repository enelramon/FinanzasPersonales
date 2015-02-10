﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Cuentas
    {
        private ConexionDb Conexion = new ConexionDb();

        public int IdCuenta { get; set; }

        public string Descripcion { get; set; }



        public Cuentas()
        {
            this.IdCuenta = 0;
            this.Descripcion = string.Empty;
        }

        public Boolean Insertar()
        {


            return Conexion.EjecutarDB("Insert Into Cuentas (Descripcion)  Values('" + this.Descripcion + "')");

        }


        public Boolean Modificar()
        {
            return false;
        }

        public Boolean Borrar()
        {
            return false;
        }

        public Boolean Buscar()
        {

            //if dt.rows.count > 0 
            //this.Descripcion =dt.rows[0]["Descripcion"];
            return false;
        }

        public DataTable Listar(string campos ="*", string Filtro="1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Cuentas where " + Filtro);
        }
    }
}