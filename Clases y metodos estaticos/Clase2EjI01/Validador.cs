using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjI01
{
    class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool cumpleRango;
            if (valor < min || valor > max)
            {
                cumpleRango = false;
            }
            else
            {
                cumpleRango = true;
            }
            return cumpleRango;
        }
    }
}
