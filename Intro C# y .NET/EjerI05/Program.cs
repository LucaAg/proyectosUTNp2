using System;

namespace EjerI05
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 numIngresado;
            Int32 centroNumerico = 1;
            Int32 acumuladorIzq = 0;
            Int32 acumuladorDer = 0;
            Int32 j = 0;
            Int32 k = 0;

            Console.WriteLine("Ingrese un numero para calcular todos los centros numericos disponibles: ");
            numIngresado = int.Parse(Console.ReadLine());
            Console.Title = "EJI05";

            for (Int32 i = 1; i <= numIngresado; i++)
            {
                centroNumerico++; // inicio el centro numerico en 2, ya que no sirve que este en 1
                k = centroNumerico + 1; // sumo el valor de k que evaluara la parte derecha del numero ingresado por usuario
                for (j = 1; j < centroNumerico; j++)
                {
                    //Console.WriteLine("J =  {0}", j);
                    acumuladorIzq += j; // acumulo la parte izquierda del numero ingresado, desde el centro numerico
                    
                }
                //Console.WriteLine("Izquierda {0}", acumuladorIzq);
                k = centroNumerico; 
                while (acumuladorIzq > acumuladorDer)
                {
                    k++; // k es igual al centro numerico yl o elevo para comenzar la sumatoria
                    acumuladorDer += k; // acumulo k
                    //Console.WriteLine("K =  {0}", k);
                    if (acumuladorDer == acumuladorIzq) // si encuentra similutudes me printea por pantalla
                    {
                        Console.WriteLine("El numero {0} es un centro numerico.", centroNumerico);
                    }
                }
                //Console.WriteLine("Derecha {0}", acumuladorDer);
                acumuladorDer = 0;
                acumuladorIzq = 0;
                k = 0; //restablezco los valores a 0 para comenzar una nueva secuencia de busqueda 
            }
        }
    }
}
