using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasPersonales
{
    public static class Utilitarios
    {
        public static  int ToInt(string texto)
        {
            int valor = 0;

            int.TryParse(texto, out valor);

            return valor;
        }
    }
}
