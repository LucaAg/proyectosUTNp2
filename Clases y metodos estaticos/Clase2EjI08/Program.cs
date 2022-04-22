using System;

namespace Clase2EjI08
{
    class Program
    {
        public static int calcularDiasVividos(DateTime fecha)
        {
            Int32 diasDiferencia;
            DateTime fechaHoy = DateTime.Now;
            TimeSpan difFechas = fechaHoy - fecha;
            diasDiferencia = difFechas.Days;
            /* for (int i = fechaHoy.Year; i < fecha.Year; i++)
             {
                 if (((i % 4) == 0) && ((i % 100) != 0))
                 {
                     diasDiferencia++;
                 }
                 else if (((i % 100) == 0) && ((i % 4) == 0))
                 {
                     if ((i % 400) == 0)
                     {
                         diasDiferencia++;
                     }
                 }
             }*/
            for (int i = fecha.Year; i < fechaHoy.Year; i++)
            {
                if(DateTime.IsLeapYear(i))
                {
                    diasDiferencia++;
                    if (fecha.Year == i && fecha.Month >= 3)
                    {
                        diasDiferencia--; // D:
                    }
                }
            }
     
            return diasDiferencia;  
        }
        static void Main(string[] args)
        {
            DateTime fechaUsuario;
            string formatoFecha;
            DateTime fechaHoy = DateTime.Now;
            Int32 difDias;
            Console.WriteLine("Ingrese su fecha de nacimiento(dd/MM/yyyy): ");
            formatoFecha = Console.ReadLine();
            fechaUsuario = DateTime.ParseExact(formatoFecha, "dd/MM/yyyy", null);
            difDias = calcularDiasVividos(fechaUsuario);
            Console.WriteLine($"La cantidad de dias desde {fechaUsuario} hasta {fechaHoy} es de {difDias}");
        }
    }
}
