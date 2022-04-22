using System;
using System.Collections.Generic;

namespace Clase06EjI02
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESTE ES EL 1 ME EQUIVOQUE XD
            int[] arrayNum = new int[20];
            Random numRandom = new Random();

            for (int i = 0; i < arrayNum.Length; i++)
            {
                arrayNum[i] = numRandom.Next(-40, 41);
                if (arrayNum[i] == 0)
                {
                    i--;
                }
            }
            //muestro el array de numeros ingresado de forma aleatoria
            Console.WriteLine("Array aleatorio : ");
            foreach (int numero in arrayNum)
            {
                Console.WriteLine(numero);
            }
            //ordeno el array con sus positivos de forma descendiente
            Array.Sort(arrayNum);
            Array.Reverse(arrayNum);
            Console.WriteLine("Array ordenado de manera descendiente, solo los postivios: ");
            foreach (int numero in arrayNum)
            {
                if(numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }

            //ordeno los numeros negativos de forma ascendente
            Array.Sort(arrayNum);
            Console.WriteLine("Array ordenado de manera ascendente, solo los negativos: ");
            foreach (int numero in arrayNum)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
