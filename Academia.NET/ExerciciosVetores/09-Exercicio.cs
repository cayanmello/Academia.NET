using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _09_Exercicio
    {
        public static void vetores()
        {
            //9.Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

            int tamanho = 10;
            int[] vetor = new int[tamanho];
            int[] vetorOrdenado = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Array.Copy(vetor, vetorOrdenado, tamanho);
            Array.Sort(vetorOrdenado);

            Console.WriteLine("Vetor Ordenado em Ordem Crescente:");
            foreach (int num in vetorOrdenado)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        }
    }
}
