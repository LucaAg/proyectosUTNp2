using System;
using BibliotecaClase04EjI05;
namespace Clase04EjI05
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit gradosFarenheit = 100;
            Celsius gradosCelsius = 18;
            Kelvin gradosKelvin = 373.15;

            /* Console.WriteLine($"Cº : {gradosCelsius.mostrarGradosCelsius(gradosCelsius)} a Fahrenheit: {gradosFarenheit.mostrarGradosFahrenheit((Fahrenheit)gradosCelsius)}");
             Console.WriteLine($"Cº : {gradosCelsius.mostrarGradosCelsius(gradosCelsius)} a Kelvin: {gradosKelvin.mostrarGradosKelvin((Kelvin)gradosCelsius):#.00}");

             Console.WriteLine($"Fº : {gradosFarenheit.mostrarGradosFahrenheit(gradosFarenheit)} a Kelvin: {gradosKelvin.mostrarGradosKelvin((Kelvin)gradosFarenheit)}");
             Console.WriteLine($"Fº : {gradosFarenheit.mostrarGradosFahrenheit(gradosFarenheit)} a Celsius: {gradosCelsius.mostrarGradosCelsius((Celsius)gradosFarenheit)}");

             Console.WriteLine($"Kº : {gradosKelvin.mostrarGradosKelvin(gradosKelvin)} a Fahrenheit: {gradosFarenheit.mostrarGradosFahrenheit((Fahrenheit)gradosKelvin)}");
             Console.WriteLine($"Kº : {gradosKelvin.mostrarGradosKelvin(gradosKelvin)} a Celsius: {gradosCelsius.mostrarGradosCelsius((Celsius)gradosKelvin)}");
            */
            Console.WriteLine($"Kº : {gradosKelvin.Temperatura} a Celsius: {((Celsius)gradosKelvin).Temperatura }");

            gradosKelvin.Temperatura = 355.15;
            Console.WriteLine($"Kº : {gradosKelvin.Temperatura} a Celsius: {((Celsius)gradosKelvin).Temperatura }");
        }
    }
}
