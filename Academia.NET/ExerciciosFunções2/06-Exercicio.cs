using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções2
{
    internal class _06_Exercicio
    {
        public static void funcoes2()
        {
            //6 - Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e um número de coluna como parâmetros, e retorna a soma dos elementos nessa coluna.

            int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("Matriz:");
            ImprimirMatriz(matriz);

            Console.Write("Digite o número da coluna que deseja calcular a soma: ");
            int numeroColuna = int.Parse(Console.ReadLine());

            int somaColuna = MediaColunaMatriz(matriz, numeroColuna);

            Console.WriteLine($"Soma dos elementos na coluna {numeroColuna}: {somaColuna}");
        }

        static int MediaColunaMatriz(int[,] matriz, int numeroColuna)
        {
            int linhas = matriz.GetLength(0);
            int soma = 0;

            for (int i = 0; i < linhas; i++)
            {
                soma += matriz[i, numeroColuna];
            }

            return soma;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
