using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções2
{
    internal class _04_Exercicio
    {
        public static void funcoes2()
        {
            //4 - Escreva uma função chamada MultiplicarMatrizes que recebe duas matrizes como parâmetros e retorna a matriz resultante da multiplicação.


            int[,] matriz1 = {
                {1, 2},
                {3, 4}
            };

            int[,] matriz2 = {
                {5, 6},
                {7, 8}
            };

            int[,] resultado = MultiplicarMatrizes(matriz1, matriz2);

            Console.WriteLine("Matriz 1:");
            ImprimirMatriz(matriz1);

            Console.WriteLine("Matriz 2:");
            ImprimirMatriz(matriz2);

            Console.WriteLine("Matriz Resultante da Multiplicação:");
            ImprimirMatriz(resultado);
        }

        static int[,] MultiplicarMatrizes(int[,] matriz1, int[,] matriz2)
        {
            int linhasMatriz1 = matriz1.GetLength(0);
            int colunasMatriz1 = matriz1.GetLength(1);
            int colunasMatriz2 = matriz2.GetLength(1);

            int[,] resultado = new int[linhasMatriz1, colunasMatriz2];

            for (int i = 0; i < linhasMatriz1; i++)
            {
                for (int j = 0; j < colunasMatriz2; j++)
                {
                    resultado[i, j] = 0;
                    for (int k = 0; k < colunasMatriz1; k++)
                    {
                        resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                    }
                }
            }

            return resultado;
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
