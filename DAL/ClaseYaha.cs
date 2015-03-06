using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace DAL
{
    class ClaseYaha
    {
        private SqlConnection conn;

        public ClaseYaha() { 
        
        conn=new SqlConnection(@"Data Source=Yahaida-PC;Initial Catalog=FinanzasPersonalesY;Integrated Security=True");
           
        }

        void ConestarASQL(){

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {

                Console.Write("erro no se conecto");
            }
        
        
        }


    }
}
