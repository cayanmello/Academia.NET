using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _16_Exercicio
    {
        public static void matrizes()
        {
            //16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
            //Transpor uma matriz significa transformar suas linhas em colunas e vice - versa.

            int[,] matrizOriginal = new int[3, 4] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

            int[,] matrizTransposta = TransporMatriz(matrizOriginal);

            Console.WriteLine("Matriz Original 3x4:");
            MostrarMatriz(matrizOriginal);

            Console.WriteLine("\nMatriz Transposta 4x3:");
            MostrarMatriz(matrizTransposta);
        }

        static int[,] TransporMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            int[,] matrizTransposta = new int[colunas, linhas];

            for (int i = 0; i < linhas; ++i)
            {
                for (int j = 0; j < colunas; ++j)
                {
                    matrizTransposta[j, i] = matriz[i, j];
                }
            }

            return matrizTransposta;
        }

        static void MostrarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; ++i)
            {
                for (int j = 0; j < colunas; ++j)
                {
                    Console.Write(matriz[i, j] + " ");
                }
            }
        }
    }
}
