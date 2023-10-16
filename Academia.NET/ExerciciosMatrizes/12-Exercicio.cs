using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _12_Exercicio
    {
        public static void matrizes()
        {
            //12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices(i + j) seja um número par.

            int linhas = 4;
            int colunas = 3;
            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine($"Digite os valores da matriz {linhas}x{colunas}:");
            for (int i = 0; i < linhas; ++i)
            {
                for (int j = 0; j < colunas; ++j)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine($"Valores cuja soma dos índices (i+j) é um número par na matriz {linhas}x{colunas}:");
            for (int i = 0; i < linhas; ++i)
            {
                for (int j = 0; j < colunas; ++j)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.WriteLine($"Elemento [{i},{j}]: {matriz[i, j]}");
                    }
                }
            }
        }
    }
}
