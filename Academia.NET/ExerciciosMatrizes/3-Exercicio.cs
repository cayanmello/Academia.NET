using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _3_Exercicio
    {
        public static void matrizes()
        {
            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            int[,] matriz = new int[4, 4];

            Console.WriteLine("Preencha a matriz 4x4:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Digite o elemento da linha {i + 1}, coluna {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Elementos da Diagonal Principal: ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(matriz[i, i]);
            }

            Console.ReadLine();
        }
    }
}
