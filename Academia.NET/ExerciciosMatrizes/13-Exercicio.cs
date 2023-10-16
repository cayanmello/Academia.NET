using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _13_Exercicio
    {
        public static void matrizes()
        {
            //13) Escreva um programa que leia uma matriz de ordem 5(ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da
            //diagonal secundária.

            int[,] matriz = new int[5, 5] {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };

            int somaDiagonalPrincipal = 0;
            for (int i = 0; i < 5; ++i)
            {
                somaDiagonalPrincipal += matriz[i, i];
            }

            int somaDiagonalSecundaria = 0;
            for (int i = 0; i < 5; ++i)
            {
                somaDiagonalSecundaria += matriz[i, 4 - i];
            }

            if (somaDiagonalPrincipal == somaDiagonalSecundaria)
            {
                Console.WriteLine($"A soma dos elementos da diagonal principal ({somaDiagonalPrincipal}) é igual à soma dos elementos da diagonal secundária ({somaDiagonalSecundaria}).");
            }
            else
            {
                Console.WriteLine($"A soma dos elementos da diagonal principal ({somaDiagonalPrincipal}) não é igual à soma dos elementos da diagonal secundária ({somaDiagonalSecundaria}).");
            }
        }
    }
}
