using System;
using System.Collections.Generic;
namespace Clase06EjI01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESTE ES EL 2 ME EQUIVOQUE XD
            List<int> listaDeNumeros = new List<int>();
            Queue<int> colaDeNumeros = new Queue<int>();
            Stack<int> pilaDeNumeros = new Stack<int>();
            Random numRandom = new Random();
            int tamañoLista= 20;

            for (int i = 0; i < tamañoLista; i++)
            {
                listaDeNumeros.Add(numRandom.Next(-100, 100));
            }
            foreach (int numero in listaDeNumeros)
            {
                colaDeNumeros.Enqueue(numero);
                pilaDeNumeros.Push(numero);
            }

            Console.WriteLine("Cola numeros: ");
            foreach(int numero in colaDeNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("\nCola lista: ");
            foreach (int numero in pilaDeNumeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("\nPila lista: ");
            foreach (int numero in listaDeNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.WriteLine("Lista de positivos de forma decreciente: ");
            listaDeNumeros.Sort();
            listaDeNumeros.Reverse();
            foreach (int numero in listaDeNumeros)
            {
                if(numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.WriteLine("Lista de negativos de forma creciente: ");
            listaDeNumeros.Sort();
            foreach (int numero in listaDeNumeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.WriteLine("COLA DE NEGATIVOS: ");
            foreach (int numero in colaDeNumeros)
            {
                if(numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.WriteLine("COLA DE POSITIVOS: ");
            foreach (int numero in colaDeNumeros)
            {
                if (numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.WriteLine("PILA DE NEGATIVOS: ");
            foreach (int numero in pilaDeNumeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.WriteLine("PILA DE POSITIVOS: ");
            foreach (int numero in pilaDeNumeros)
            {
                if (numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
