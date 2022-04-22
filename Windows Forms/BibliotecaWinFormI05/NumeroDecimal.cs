﻿using System;

namespace BibliotecaWinFormI05
{
    public class NumeroDecimal
    {

        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroDecimal(double numeroDecimal)
        {
            return new NumeroDecimal(numeroDecimal);
        }

        public static explicit operator double(NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.numero;
        }
        
        public static explicit operator NumeroBinario(NumeroDecimal numDec)
        {
            return Conversor2.ConvertirDecimalABinario(numDec.numero);
        }

        public double MostrarDec
        {
            get { return numero; }
        }
        public static double operator +(NumeroDecimal numDec, NumeroBinario numBin)
        {
            double numBinADecimal = Conversor2.ConvertirBinarioADecimal(Convert.ToDouble(((string)numBin)));
            numBinADecimal += ((double)numDec);
            return numBinADecimal;
        }

        public static double operator -(NumeroDecimal numDec, NumeroBinario numBin)
        {
            double numBinADecimal = Conversor2.ConvertirBinarioADecimal(Convert.ToDouble(((string)numBin)));
            numBinADecimal -= ((double)numDec);
            return numBinADecimal;
        }

        public static bool operator ==(NumeroDecimal numDec, NumeroBinario numBin)
        {
            double numBinADecimal = Convert.ToDouble(((string)numBin));
            return numBinADecimal == ((double)numDec);
        }

        public static bool operator !=(NumeroDecimal numDec, NumeroBinario numBin)
        {
            return !(numBin == ((double)numDec));
        }
    }
}
