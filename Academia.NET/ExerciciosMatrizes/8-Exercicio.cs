using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _8_Exercicio
    {
        public static void matrizes()
        {
            //8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            int[,] matriz = new int[4, 4];

            Console.WriteLine("Insira os elementos da matriz 4x4:");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Digite o elemento da posição [{i},{j}]: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        matriz[i, j] = valor;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira um número válido.");
                        j--;
                    }
                }
            }

            Console.WriteLine("Números na ordem direta:");
            ImprimirMatriz(matriz);

            Console.WriteLine("Números na ordem inversa:");
            ImprimirMatrizInversa(matriz);

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

        static void ImprimirMatrizInversa(int[,] matriz)
        {
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
