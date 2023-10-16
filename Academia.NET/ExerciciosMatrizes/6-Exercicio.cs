using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _6_Exercicio
    {
        public static void matrizes()
        {
            //6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0 - 9.Após isso determine o maior número da matriz.
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);

            int[,] matriz = new int[4, 4];

            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }

            Console.WriteLine("Matriz gerada:");
            ImprimirMatriz(matriz);

            int maiorNumero = EncontrarMaiorNumero(matriz);

            Console.WriteLine($"O maior número na matriz é: {maiorNumero}");

            Console.ReadLine();
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int EncontrarMaiorNumero(int[,] matriz)
        {
            int maiorNumero = matriz[0, 0];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] > maiorNumero)
                    {
                        maiorNumero = matriz[i, j];
                    }
                }
            }

            return maiorNumero;
        }
    }
}
