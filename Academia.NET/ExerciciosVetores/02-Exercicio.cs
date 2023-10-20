using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _02_Exercicio
    {
        public static void vetores()
        {
            //1) Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição,
            //armazenando o resultado em um outro vetor.

            int tamanho = 20;
            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];
            int[] resultado = new int[tamanho];

            Console.WriteLine("Digite 20 números para o primeiro vetor");

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite 20 números para o segundo vetor");


            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = vetor1[i] + vetor2[i];
            }

            Console.WriteLine("Resultado da soma dos vetores:");
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {resultado[i]}");
            }
        }
    }
}
