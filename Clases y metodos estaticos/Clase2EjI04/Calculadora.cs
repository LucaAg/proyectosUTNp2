using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjI04
{
    class Calculadora
    {
        private static bool Validar(Single numero2)
        {
            bool NoEsCero=true;
            if(numero2 == 0)
            {
                NoEsCero = false;
            }
            return NoEsCero;
        }

        public static Single Calcular(Single numero1, Single numero2, char operador)
        {
            Single resultado = 0;
            switch(operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if (Calculadora.Validar(numero2) == true)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Error, no se puede dividir por 0.");
                    }
                    break;
                default:
                    Console.WriteLine("Error, operador no valido.");
                    break;
            }
            return resultado;
        }
    }
}
