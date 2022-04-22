using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2EjI03
{
    class Conversor
    {
        public static string ConvertirDecimalABinario(Int32 numeroEntero)
        {
            Int32 restoNum;
            string numBinario = "";
            string nuevaString = "";
            while (numeroEntero > 0)
            {
                restoNum = numeroEntero % 2;
                numeroEntero = numeroEntero / 2;
                numBinario += restoNum;
            }
            for (int i = numBinario.Length - 1; i >= 0; i--)
            {
                nuevaString += numBinario[i];
            }
            return nuevaString;
        }
        
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string num = Convert.ToString(numeroEntero);
            string numAlReves = "";
            Int32 numDecimal = 0;
            for (int i = num.Length - 1 ; i >= 0; i--)
            {
                numAlReves += num[i];
            }

            for (int i = 0; i < numAlReves.Length; i++)
            {
                if (numAlReves[i] == '1')
                {
                    numDecimal += (int)Math.Pow(2, i);
                }
            }
            return numDecimal;
        }
    }
}
