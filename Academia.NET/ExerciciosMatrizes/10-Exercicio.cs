using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _10_Exercicio
    {
        public static void matrizes()
        {
            //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];

            Console.WriteLine("Digite os valores para a matriz A:");
            PreencherMatriz(matrizA);

            Console.WriteLine("Digite os valores para a matriz B:");
            PreencherMatriz(matrizB);

            double mediaA = CalcularMedia(matrizA);
            double mediaB = CalcularMedia(matrizB);

            int abaixoMediaA = ContarElementosAbaixoMedia(matrizA, mediaA);
            int acimaMediaA = ContarElementosAcimaMedia(matrizA, mediaA);
            int MediaA = ContarElementosNaMedia(matrizA, mediaA);

            int abaixoMediaB = ContarElementosAbaixoMedia(matrizB, mediaB);
            int acimaMediaB = ContarElementosAcimaMedia(matrizB, mediaB);
            int MediaB = ContarElementosNaMedia(matrizB, mediaB);

            Console.WriteLine($"Média da matriz A: {mediaA}");
            Console.WriteLine($"Elementos abaixo da média na matriz A: {abaixoMediaA}");
            Console.WriteLine($"Elementos acima da média na matriz A: {acimaMediaA}");
            Console.WriteLine($"Elementos na média na matriz A: {MediaA}");

            Console.WriteLine($"Média da matriz B: {mediaB}");
            Console.WriteLine($"Elementos abaixo da média na matriz B: {abaixoMediaB}");
            Console.WriteLine($"Elementos acima da média na matriz B: {acimaMediaB}");
            Console.WriteLine($"Elementos na média na matriz B: {MediaB}");
        }

        static void PreencherMatriz(int[,] matriz)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static double CalcularMedia(int[,] matriz)
        {
            double soma = 0;
            foreach (int elemento in matriz)
            {
                soma += elemento;
            }
            return soma / (matriz.GetLength(0) * matriz.GetLength(1));
        }

        static int ContarElementosAbaixoMedia(int[,] matriz, double media)
        {
            int contador = 0;
            foreach (int elemento in matriz)
            {
                if (elemento < media)
                {
                    contador++;
                }
            }
            return contador;
        }

        static int ContarElementosAcimaMedia(int[,] matriz, double media)
        {
            int contador = 0;
            foreach (int elemento in matriz)
            {
                if (elemento > media)
                {
                    contador++;
                }
            }
            return contador;
        }

        static int ContarElementosNaMedia(int[,] matriz, double media)
        {
            int contador = 0;
            foreach (int elemento in matriz)
            {
                if (elemento == media)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
