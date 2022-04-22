using System;

namespace EJI07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJI07";

            Single valorHora;
            string nombreEmp;
            Single antiguedadEmp;
            Single horasTrabajadas;
            string respuesta = "si";
            Single totalBruto;
            Single totalNeto;

            do
            {
                Console.WriteLine("Ingrese el valor hora: ");
                valorHora = Single.Parse(Console.ReadLine());
                while(valorHora < 1)
                {
                    Console.WriteLine("Error, debe ingresar un numero mayor a 0. Vuelva a ingresarlo: ");
                    valorHora = Single.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese el nombre del empleado/a: ");
                nombreEmp = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad en años del empleado/a: ");
                antiguedadEmp = Single.Parse(Console.ReadLine());
                while (antiguedadEmp < 0)
                {
                    Console.WriteLine("Error, debe ingresar un numero mayor o igual a 0. Vuelva a ingresarlo: ");
                    antiguedadEmp = Single.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes: ");
                horasTrabajadas = Single.Parse(Console.ReadLine());
                while (horasTrabajadas < 0)
                {
                    Console.WriteLine("Error, debe ingresar un numero mayor o igual a 0. Vuelva a ingresarlo: ");
                    horasTrabajadas = Single.Parse(Console.ReadLine());
                }

                totalBruto = (valorHora * horasTrabajadas) + (antiguedadEmp * 150); 
                totalNeto = totalBruto - (totalBruto * 13 / 100);

                Console.WriteLine("Empleado: {0}\nAntiguedad: {1}\nValor hora: {2}\nTotal a cobrar en bruto: {3}\n" +
                    "Total a cobrar en neto: {4}",nombreEmp, antiguedadEmp, valorHora, totalBruto, totalNeto);

                Console.WriteLine("Desea ingresar datos de otro empleado/a? (SI/NO)");
                respuesta = Console.ReadLine();

                while (respuesta != "SI" && respuesta != "NO")
                {
                    Console.WriteLine("Error, debe ingresar SI o NO. Vuevla a intentarlo: ");
                    respuesta = Console.ReadLine();
                }
            } while (respuesta == "SI");
           
        }
    }
}
