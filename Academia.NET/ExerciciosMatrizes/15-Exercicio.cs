using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _15_Exercicio
    {
        public static void matrizes()
        {
            //15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

            int tamanho = 4;
            int[,] matriz1 = new int[tamanho, tamanho];
            int[,] matriz2 = new int[tamanho, tamanho];
            int[,] matrizResultado = new int[tamanho, tamanho];

            Console.WriteLine("Digite os valores da primeira matriz 4x4:");
            LerMatriz(matriz1);

            Console.WriteLine("Digite os valores da segunda matriz 4x4:");
            LerMatriz(matriz2);

            for (int i = 0; i < tamanho; ++i)
            {
                for (int j = 0; j < tamanho; ++j)
                {
                    matrizResultado[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Matriz resultante da soma das duas matrizes:");
            MostrarMatriz(matrizResultado);
        }

        static void LerMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void MostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
