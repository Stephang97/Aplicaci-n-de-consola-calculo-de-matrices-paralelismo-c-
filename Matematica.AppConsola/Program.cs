using System;
using System.Globalization;

namespace Matematica.AppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int[,] matrizA = new int[2, 3];
            matrizA[0, 0] = 1;
            matrizA[0, 1] = 2;
            matrizA[0, 2] = 4;
            matrizA[1, 0] = 2;
            matrizA[1, 1] = 5;
            matrizA[1, 2] = 8;

            int[,] matrizB = new int[3, 5];

            matrizB[0, 0] = 4;
            matrizB[0, 1] = 9;
            matrizB[0, 2] = 2;
            matrizB[0, 3] = 7;
            matrizB[0, 4] = 3;

            matrizB[1, 0] = 1;
            matrizB[1, 1] = 3;
            matrizB[1, 2] = 3;
            matrizB[1, 3] = 4;
            matrizB[1, 4] = 7;

            matrizB[2, 0] = 6;
            matrizB[2, 1] = 5;
            matrizB[2, 2] = 4;
            matrizB[2, 3] = 1;
            matrizB[2, 4] = 9;
           */ // SE INTERCAMBIA POR LAS LINEAS 40 y 41

            Calculadora calculadora = new Calculadora();
            int[,] matrizA = calculadora.Crearmatriz(2, 3); //Tamaño de la matriz
            int[,] matrizB = calculadora.Crearmatriz(3, 4); //Tamaño de la matriz

            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[,] matrizAxB = calculadora.Multiplicar(matrizA, matrizB);
            watch.Stop();
            var tiempoEnTicks = watch.ElapsedTicks;
            Console.WriteLine($"tiempo transcurrido en ticks {tiempoEnTicks}");
            for (int i = 0; i < matrizAxB.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrizAxB.GetLength(1); j++)
                {
                    Console.Write($"{matrizAxB[i, j]}\t");
                }
            }
            Console.ReadKey();

        }
    }
}
