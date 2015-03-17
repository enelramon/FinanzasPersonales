using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetReporte( ReportClass r )
        {
            crystalReportViewer1.ReportSource = r;
    }

        private void button1_Click(object sender, EventArgs e)
        {


            SetReporte(new Reportes.ListadoUsuarios());

            FinanzasPersonalesDBEntities1 db = new FinanzasPersonalesDBEntities1();

            Cuenta c = new Cuenta();

            c.Descripcion = "";
            c.Balance = 0;

            db.Cuentas.Add(c);
            db.SaveChanges();

        }
    }
}
