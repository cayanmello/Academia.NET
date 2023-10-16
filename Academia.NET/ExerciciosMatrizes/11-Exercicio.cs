using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _11_Exercicio
    {
        public static void matrizes()
        {
            //11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

            int tamanho = 3;
            double[,] matrizA = new double[tamanho, tamanho];
            double[,] matrizResultado = new double[tamanho, tamanho];

            Console.WriteLine("Digite os elementos da matriz 3x3:");
            for (int i = 0; i < tamanho; ++i)
            {
                for (int j = 0; j < tamanho; ++j)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizA[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double somaIndices = 0;
            for (int i = 0; i < tamanho; ++i)
            {
                for (int j = 0; j < tamanho; ++j)
                {
                    somaIndices += i + j;
                }
            }

            for (int i = 0; i < tamanho; ++i)
            {
                for (int j = 0; j < tamanho; ++j)
                {
                    matrizResultado[i, j] = matrizA[i, j] / somaIndices;
                }
            }

            Console.WriteLine("Resultado da divisão dos elementos pelo somatório dos índices:");
            for (int i = 0; i < tamanho; ++i)
            {
                for (int j = 0; j < tamanho; ++j)
                {
                    Console.Write(matrizResultado[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
