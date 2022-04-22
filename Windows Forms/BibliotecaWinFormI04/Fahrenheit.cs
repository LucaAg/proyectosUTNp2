using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWinFormI04
{
    public class Fahrenheit
    {

        private static double valorFarenheit;
        private double gradosFarenheit;

        static Fahrenheit()
        {
            valorFarenheit = 459.67;
        }

        public Fahrenheit(double gradosFarenheit)
        {
            this.gradosFarenheit = gradosFarenheit;
        }

        public double GetGrados()
        {
            return this.gradosFarenheit;
        }

        public static double GetValorDeterminado()
        {
            return Fahrenheit.valorFarenheit;
        }

        public static explicit operator Celsius(Fahrenheit gradosFarenheit)
        {
            return new Celsius((gradosFarenheit.GetGrados() - Celsius.GetValorDeterminado()) * 5 / 9);
        }

        public static explicit operator Kelvin(Fahrenheit gradosFarenheit)
        {
            return new Kelvin((gradosFarenheit.GetGrados() + Fahrenheit.GetValorDeterminado()) * 5 / 9);
        }

        public static implicit operator Fahrenheit(double grados)
        {
            return new Fahrenheit(grados);
        }

        public string mostrarGradosFahrenheit(Fahrenheit grados)
        {
            StringBuilder datosgradosFarenheit = new StringBuilder();
            datosgradosFarenheit.Append($"{grados.GetGrados()}");
            return datosgradosFarenheit.ToString();
        }

        public double Temperatura
        {
            get { return this.gradosFarenheit; }
            set { this.gradosFarenheit = value; }
        }
    }
}
