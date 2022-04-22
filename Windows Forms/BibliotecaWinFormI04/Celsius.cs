using System;
using System.Text;

namespace BibliotecaWinFormI04
{
    public class Celsius
    {
        private static double valorCelsius;
        private double gradosCelsius;
        static Celsius()
        {
            valorCelsius = 32;
        }

        public Celsius(double gradosCelsius)
        {
            //this.valorCelsius = 32;
            this.gradosCelsius = gradosCelsius;
        }

        public double GetGrados()
        {
            return this.gradosCelsius;
        }

        public static double GetValorDeterminado()
        {
            return Celsius.valorCelsius;
        }

        public static explicit operator Kelvin(Celsius gradosCelsius)
        {
            return new Kelvin(gradosCelsius.GetGrados() + Kelvin.GetValorDeterminado());
        }

        public static explicit operator Fahrenheit(Celsius gradosCelsius)
        {
            return new Fahrenheit(gradosCelsius.GetGrados() * 9 / 5 + Celsius.GetValorDeterminado());
        }

        public static implicit operator Celsius(double grados)
        {
            return new Celsius(grados);
        }

        public string mostrarGradosCelsius(Celsius grados)
        {
            StringBuilder datosCelsius = new StringBuilder();
            datosCelsius.Append($"{grados.GetGrados()}");
            return datosCelsius.ToString();
        }

        public double Temperatura
        {
            get { return this.gradosCelsius; }
            set { this.gradosCelsius = value; }
        }
    }
}
