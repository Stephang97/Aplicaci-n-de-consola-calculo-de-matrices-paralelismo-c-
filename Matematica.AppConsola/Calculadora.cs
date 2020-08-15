using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Matematica.AppConsola
{
    internal class Calculadora
    {
        public int[,] Multiplicar(int[,] matrizA, int[,] matrizB)
        {
            int filas = matrizA.GetLength(0);
            int columnas = matrizB.GetLength(1);
            int columnasA = matrizA.GetLength(1);
            int[,] matrizAxB = new int[filas, columnas];
            //Paralelismo 
            Parallel.For(0, filas, i =>
           {
               for (int j = 0; j < columnas; j++)
               {
                    //columnas matriz A
                    int acumulador = 0; //para almacenar los calculos hechos
                   for (int k = 0; k < columnasA; k++)
                   {
                       //se suma y se multiplica
                       acumulador += matrizA[i, k] * matrizB[k, j];
                   }
                   matrizAxB[i, j] = acumulador;
               }
           });
            return matrizAxB;

        }

        internal int[,] Crearmatriz(int fila, int columna)
        {
            var generador = new Random();
            int[,] matriz = new int[fila, columna];
            Parallel.For(0, fila, i =>
           {
               for (int j = 0; j < columna; j++)
               {
                   matriz[i, j] = generador.Next(10, 40); //rango de los numeros de las matrices
                }

           });
            return matriz;
        }
    }
}
