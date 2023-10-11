using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _2_Exercicio
    {
        public static void matrizes()
        {
            //2) Solicite ao usuário, preencher uma Matriz 3x3

            //Informe ao usuário:
            //* A soma dos elementos de cada linha
            //    -Ex: Linha 1: 30
            //         Linha 2: 17
            //* A soma dos elementos de cada coluna
            //    -Ex: Coluna 1: 23
            //         Coluna 2: 36

            int[,] matriz = new int[3, 3];

            Console.WriteLine("Preencha a matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o elemento da linha {i + 1}, coluna {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("A soma das linhas e colunas são:");

            for (int i = 0; i < 3; i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < 3; j++)
                {
                    somaLinha += matriz[i, j];
                }
                Console.WriteLine($"Linha {i + 1}: {somaLinha}");
            }

            for (int j = 0; j < 3; j++)
            {
                int somaColuna = 0;
                for (int i = 0; i < 3; i++)
                {
                    somaColuna += matriz[i, j];
                }
                Console.WriteLine($"Coluna {j + 1}: {somaColuna}");
            }
        }
    }
}
