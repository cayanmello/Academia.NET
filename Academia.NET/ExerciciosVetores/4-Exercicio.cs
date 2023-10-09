using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _4_Exercicio
    {
        public static void vetores()
        {
            //4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice,
            //    colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

            int tamanho = 10;
            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];
            int[] resultado = new int[tamanho];

            Console.WriteLine("Digite 10 números para o primeiro vetor");

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite 10 números para o segundo vetor");


            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < resultado.Length; i++)
            {
                resultado[i] = vetor1[i] * vetor2[i];
            }

            Console.WriteLine("Resultado da soma dos vetores:");
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: {resultado[i]}");
            }
        }
    }
}
