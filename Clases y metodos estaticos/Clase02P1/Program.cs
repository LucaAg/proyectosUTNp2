using System;

namespace Clase02P1
{
    public class Sello
    {
        public static string mensaje;

        public static ConsoleColor color;

        public static string Imprimir()
        {
            string mensajeFormateado;
            if(Sello.TryParse(Sello.mensaje, out mensajeFormateado) )
            {
                return Sello.ArmarFormatoMensaje();
            }
            else
            {
                return "";
            }
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine(Sello.Imprimir());
        }

        private static string ArmarFormatoMensaje()
        {
            int length = Sello.mensaje.Length;
            string linea = "";
            for (int i = 0; i < length + 2; i++)
			{
                linea += "*";   
			}
             return linea + "\n*" + Sello.mensaje + "*\n" + linea;

        }

        private static bool TryParse(string cadena1, out string cadena2)
        {
            if(cadena1.Length > 0)
            {
                cadena2 = Sello.ArmarFormatoMensaje();
                return true;    
            }
            else
            {
                cadena2 = "";
                return false;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola mundo"; //asigno mensaje
            Console.WriteLine(Sello.Imprimir()); // retorna string
            Console.ReadLine();
            Sello.Borrar(); //borro el mensaje
            Console.WriteLine(Sello.Imprimir());// retorna string

            //P2
            Sello.mensaje = "hola mundo C#";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();

            Console.ReadLine();
        }
    }
}
