using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções2
{
    internal class _5_Exercicio
    {
        public static void funcoes2()
        {
            //5 - Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz quadrada como parâmetro e retorna a soma dos elementos na diagonal principal.


            int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int somaDiagonalPrincipal = SomaDiagonalPrincipal(matriz);

            Console.WriteLine("Matriz:");
            ImprimirMatriz(matriz);

            Console.WriteLine($"Soma da Diagonal Principal: {somaDiagonalPrincipal}");
        }

        static int SomaDiagonalPrincipal(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            int soma = 0;

            for (int i = 0; i < tamanho; i++)
            {
                soma += matriz[i, i];
            }

            return soma;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
