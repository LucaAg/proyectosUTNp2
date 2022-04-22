using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase04EjI03
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numString)
        {
            this.numero = numString;
        }

        public static explicit operator string(NumeroBinario numBinario)
        {
            return numBinario.numero;
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }
        public static string operator +(NumeroBinario numBin, NumeroDecimal numDec)
        {
            string retorno;
            double numBinADecimal = Conversor.ConvertirBinarioADecimal(Convert.ToDouble(numBin.numero));
            numBinADecimal += ((double)numDec);
            retorno = Conversor.ConvertirDecimalABinario(numBinADecimal);
            return retorno;
        }

        public static string operator -(NumeroBinario numBin, NumeroDecimal numDec)
        {
            string retorno;
            double numBinADecimal = Conversor.ConvertirBinarioADecimal(Convert.ToDouble(numBin.numero));
            numBinADecimal -= ((double)numDec);
            retorno = Conversor.ConvertirDecimalABinario(numBinADecimal);
            return retorno;
        }

        public static bool operator ==(NumeroBinario numBin, NumeroDecimal numDec)
        {
            double numBinADecimal = Convert.ToDouble(numBin.numero);
            return numBinADecimal == ((double)numDec);
        }

        public static bool operator !=(NumeroBinario numBin, NumeroDecimal numDec)
        {
            return !(numBin == ((double)numDec));
        }
    }
}
