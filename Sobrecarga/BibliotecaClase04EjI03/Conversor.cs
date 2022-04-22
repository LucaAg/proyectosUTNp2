using System;

namespace BibliotecaClase04EjI03
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(double numeroEntero)
        {
            double restoNum;
            string numBinario = "";
            string nuevaString = "";
            int numeroCast = (int)numeroEntero;
            while (numeroCast != 0)
            {
                restoNum = numeroCast % 2;
                numeroCast = numeroCast / 2;
                numBinario += restoNum;
            }
            for (int i = numBinario.Length - 1; i >= 0; i--)
            {
                nuevaString += numBinario[i];
            }
            for (int i = numBinario.Length - 1; i >= 0; i--)
            {
                if(nuevaString[i] == '-')
                {
                    nuevaString = "No existen numeros binarios negativos.";
                    break;
                }
            }

            return nuevaString;
        }

        public static double ConvertirBinarioADecimal(double numeroEntero)
        {
            string num = Convert.ToString(numeroEntero);
            string numAlReves = "";
            double numDecimal = 0;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                numAlReves += num[i];
            }

            for (int i = 0; i < numAlReves.Length; i++)
            {
                if (numAlReves[i] == '1')
                {
                    numDecimal += (double)Math.Pow(2, i);
                }
            }
            return numDecimal;
        }
    }
}

