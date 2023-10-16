using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _17_Exercicio
    {
        public static void matrizes()
        {
            //17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o
            //maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.


            int linhas = 10;
            int colunas = 10;
            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine("Digite os elementos da matriz 10x10:");
            PreencherMatriz(matriz);

            // Encontrar o elemento minimax e suas coordenadas
            int linhaMaiorElemento = 0;
            int colunaMaiorElemento = 0;
            int maiorElemento = EncontrarMaiorElemento(matriz, ref linhaMaiorElemento, ref colunaMaiorElemento);
            int elementoMinimax = EncontrarElementoMinimax(matriz, linhaMaiorElemento);

            Console.WriteLine($"O menor elemento da linha onde se encontra o maior elemento da matriz é {elementoMinimax}.");
            Console.WriteLine($"A posição do maior elemento é: Linha {linhaMaiorElemento}, Coluna {colunaMaiorElemento}.");
        }

        static void PreencherMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int EncontrarMaiorElemento(int[,] matriz, ref int linha, ref int coluna)
        {
            int maior = matriz[0, 0];
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                for (int j = 0; j < matriz.GetLength(1); ++j)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        linha = i;
                        coluna = j;
                    }
                }
            }
            return maior;
        }

        static int EncontrarElementoMinimax(int[,] matriz, int linha)
        {
            int minimax = matriz[linha, 0];
            for (int j = 1; j < matriz.GetLength(1); ++j)
            {
                if (matriz[linha, j] < minimax)
                {
                    minimax = matriz[linha, j];
                }
            }
            return minimax;
        }
    }
}
