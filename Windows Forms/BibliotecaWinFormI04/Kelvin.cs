using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWinFormI04
{
    public class Kelvin
    {
        private static double valorKelvin;
        private double gradosKelvin;
        static Kelvin()
        {
            valorKelvin = 273.15;
        }

        public Kelvin(double gradosKelvin)
        {
            this.gradosKelvin = gradosKelvin;
        }

        public double GetGrados()
        {
            return this.gradosKelvin;
        }

        public static double GetValorDeterminado()
        {
            return Kelvin.valorKelvin;
        }

        public static explicit operator Celsius(Kelvin gradosKelvin)
        {
            return new Celsius(gradosKelvin.GetGrados() - Kelvin.GetValorDeterminado());
        }

        public static explicit operator Fahrenheit(Kelvin gradosKelvin)
        {
            return new Fahrenheit(gradosKelvin.GetGrados() * 9 / 5 - Fahrenheit.GetValorDeterminado());
        }

        public static implicit operator Kelvin(double grados)
        {
            return new Kelvin(grados);
        }

        public string mostrarGradosKelvin(Kelvin grados)
        {
            StringBuilder datosgradosKelvin = new StringBuilder();
            datosgradosKelvin.Append($"{grados.GetGrados()}");
            return datosgradosKelvin.ToString();
        }

        public double Temperatura
        {
            get { return this.gradosKelvin; }
            set { this.gradosKelvin = value; }
        }

    }
}
