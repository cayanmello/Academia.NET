using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções2
{
    internal class _1_Exercicio
    {
        public static void funcoes2()
        {
            //1 - Na teoria dos Sistemas, define - se como elemento minimax de uma matriz, o menor elemento da linha em que se encontra o maior elemento da matriz.
            //Escreva um programa que lê uma matriz[10 X 10] e em uma função encontre e mostre o elemento minimax e sua posição na matriz.

            int[,] matriz = {
            {10, 20, 30, 40, 50, 60, 70, 80, 90, 100},
            {9, 18, 27, 36, 45, 54, 63, 72, 81, 90},
            {8, 16, 24, 32, 40, 48, 56, 64, 72, 80},
            {7, 14, 21, 28, 35, 42, 49, 56, 63, 70},
            {6, 12, 18, 24, 30, 36, 42, 48, 54, 60},
            {5, 10, 15, 20, 25, 30, 35, 40, 45, 50},
            {4, 8, 12, 16, 20, 24, 28, 32, 36, 40},
            {3, 6, 9, 12, 15, 18, 21, 24, 27, 30},
            {2, 4, 6, 8, 10, 12, 14, 16, 18, 20},
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        };

            int linhaMax = 0;
            int colunaMax = 0;
            int maximo = matriz[0, 0];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] > maximo)
                    {
                        maximo = matriz[i, j];
                        linhaMax = i;
                        colunaMax = j;
                    }
                }
            }

            int minimax = matriz[linhaMax, 0];

            for (int j = 1; j < 10; j++)
            {
                if (matriz[linhaMax, j] < minimax)
                {
                    minimax = matriz[linhaMax, j];
                }
            }

            Console.WriteLine("Matriz:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nO elemento minimax é: {minimax}");
            Console.WriteLine($"Ele está na posição: [{linhaMax}, {colunaMax}]");
        }
    }
}
