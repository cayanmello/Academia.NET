using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _4_Exercicio
    {
        public static void matrizes()
        {
            int[,] matriz = new int[5, 5];

            int numerosPares = 0;
            int numerosImpares = 0;
            int numerosPositivos = 0;
            int numerosNegativos = 0;
            int zeros = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Digite o elemento da posição [{i},{j}]: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        matriz[i, j] = valor;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        numerosPares++;
                    }
                    else
                    {
                        numerosImpares++;
                    }

                    if (matriz[i, j] > 0)
                    {
                        numerosPositivos++;
                    }
                    else if (matriz[i, j] < 0)
                    {
                        numerosNegativos++;
                    }
                    else
                    {
                        zeros++;
                    }
                }
            }

            Console.WriteLine($"Quantidade de números pares: {numerosPares}");
            Console.WriteLine($"Quantidade de números ímpares: {numerosImpares}");
            Console.WriteLine($"Quantidade de números positivos: {numerosPositivos}");
            Console.WriteLine($"Quantidade de números negativos: {numerosNegativos}");
            Console.WriteLine($"Quantidade de zeros: {zeros}");

            Console.ReadLine();
        }
    }
}
