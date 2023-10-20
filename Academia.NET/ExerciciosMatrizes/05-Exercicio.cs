using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _05_Exercicio
    {
        public static void matrizes()
        {
            //5) Leia duas matrizes 2x3 de números double.
            //Imprima a soma destas duas matrizes.

            int linhas = 2;
            int colunas = 3;

            double[,] matriz1 = new double[linhas, colunas];
            double[,] matriz2 = new double[linhas, colunas];
            double[,] somaMatrizes = new double[linhas, colunas];

            Console.WriteLine("Insira os elementos da primeira matriz:");
            LerMatriz(matriz1);

            Console.WriteLine("Insira os elementos da segunda matriz:");
            LerMatriz(matriz2);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    somaMatrizes[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Soma das matrizes:");
            ImprimirMatriz(somaMatrizes);

            Console.ReadLine();
        }

        static void LerMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Digite o elemento da posição [{i},{j}]: ");
                    if (double.TryParse(Console.ReadLine(), out double valor))
                    {
                        matriz[i, j] = valor;
                    }
                }
            }
        }

        static void ImprimirMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
