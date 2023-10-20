using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _07_Exercicio
    {
        public static void matrizes()
        {
            //7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            int linhas = 3;
            int colunas = 3;

            int[,] matrizA = new int[linhas, colunas];
            int[,] matrizB = new int[linhas, colunas];
            int[,] matrizC = new int[linhas, colunas];

            Console.WriteLine("Insira os elementos da matriz A:");
            LerMatriz(matrizA, linhas, colunas);

            Console.WriteLine("Insira os elementos da matriz B:");
            LerMatriz(matrizB, linhas, colunas);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            Console.WriteLine("Matriz resultante da subtração (C = A - B):");
            ImprimirMatriz(matrizC, linhas, colunas);

            Console.ReadLine();
        }

        static void LerMatriz(int[,] matriz, int linhas, int colunas)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Digite o elemento da posição [{i},{j}]: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        matriz[i, j] = valor;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira um número válido.");
                        j--;
                    }
                }
            }
        }

        static void ImprimirMatriz(int[,] matriz, int linhas, int colunas)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
