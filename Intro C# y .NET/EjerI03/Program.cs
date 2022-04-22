 using System;

namespace EjerI03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esNumero = false;
            bool esPrimo = true;
            string salida;
            string respuesta;
            Int32 flagSalida = 0;
            Int32 num_1 = 0;
            Console.Title = "EJI03";
            do
            {
                if(flagSalida == 1)
                {
                    Console.WriteLine("Desea volver a intentarlo?(SEGUIR/SALIR)");
                    salida = Console.ReadLine();
                    while(salida != "SEGUIR" && salida != "SALIR" )
                    {
                        Console.WriteLine("Eror debe ingresar SEGUIR / SALIR");
                        salida = Console.ReadLine();
                    }
                    if (salida == "SALIR")
                    {
                        esNumero = true;
                    }
                    else
                    {
                        flagSalida = 0;
                    }
                }
                if (flagSalida == 0)
                {
                    Console.WriteLine("Ingrese un numero entero, solo se permiten numeros: ");
                    esNumero = int.TryParse(Console.ReadLine(), out num_1);
                    flagSalida = 1;
                }
                if(esNumero == true)
                {
                    for (int i = 2; i < num_1; i++)
                    {
                        esPrimo = true;
                        for (int k = 2; k < i; k++)
                        {
                            if ((i % k) == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }
                        if(esPrimo)
                        {
                            Console.WriteLine("El numero {0} es primo",i);
                        }
                    }
                    Console.WriteLine("Desea volver a ingresar otro numero? (SI/NO)");
                    respuesta = Console.ReadLine();
                    while( respuesta != "SI" && respuesta != "NO" )
                    {
                        Console.WriteLine("Error, debe ingresar SI o NO. Vuevla a intentarlo: ");
                        respuesta = Console.ReadLine();
                    }
                    if(respuesta == "SI")
                    {
                        esNumero = false;
                        flagSalida = 0;
                    }
                } 
            }while (!esNumero);        
        }
    }
}
