using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjI02
{
    class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            bool estadoRespuesta = true;
            if(respuesta != 'S')
            {
                estadoRespuesta = false;
            }

            return estadoRespuesta;
        }
    }
}
