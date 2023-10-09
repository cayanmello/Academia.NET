using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _5_Exercicio
    {
        public static void vetores()
        {
            //5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

            int tamanho = 80;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int menorElemento = vetor[0];
            int posicaoMenorElemento = 0;

            for (int i = 1; i < tamanho; i++)
            {
                if (vetor[i] < menorElemento)
                {
                    menorElemento = vetor[i];
                    posicaoMenorElemento = i;
                }
            }

            Console.WriteLine($"Menor elemento: {menorElemento}");
            Console.WriteLine($"Posição do menor elemento: {posicaoMenorElemento}");

            Console.ReadLine();
        }
    }
}
