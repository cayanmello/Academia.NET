using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _01_Exercicio
    {
        public static void matrizes()
        {
            //1) Crie uma Matriz 5x3.
            //Na primeira coluna, solicite que o usuário preencha.
            //A 2ª coluna, some 10 aos elementos da 1ª coluna.
            //Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            int[,] matriz = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o valor para a posição [{i}, 0], ");
                matriz[i, 0] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                matriz[i, 1] = matriz[i, 0] + 10;
            }

            for (int i = 0; i < 5; i++)
            {
                matriz[i, 2] = matriz[i, 0] * 2;
            }

            Console.WriteLine("Resultado da matriz:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
