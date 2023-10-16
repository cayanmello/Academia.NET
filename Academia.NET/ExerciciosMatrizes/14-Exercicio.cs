using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _14_Exercicio
    {
        public static void matrizes()
        {
            //14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal(da esquerda para a direita)
            //são os mesmos da diagonal secundária(direita pra esquerda).

            int[,] matriz = new int[5, 5] {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };

            // Verificar se os elementos da diagonal principal são iguais aos da diagonal secundária
            bool diagonaisIguais = true;
            for (int i = 0; i < 5; ++i)
            {
                if (matriz[i, i] != matriz[i, 4 - i])
                {
                    diagonaisIguais = false;
                    break;
                }
            }

            if (diagonaisIguais)
            {
                Console.WriteLine("Os elementos da diagonal principal são iguais aos da diagonal secundária.");
            }
            else
            {
                Console.WriteLine("Os elementos da diagonal principal não são iguais aos da diagonal secundária.");
            }
        }
    }
}
