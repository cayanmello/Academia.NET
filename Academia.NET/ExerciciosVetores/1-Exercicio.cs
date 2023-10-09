using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _1_Exercicio
    {
        public static void vetores()
        {
            //1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            int tamanho = 10;
            int[] vetor = new int[tamanho];
            int pares = 0;
            int impares = 0;

            Console.WriteLine("Digite 10 números para os vetores");
            Console.Write("Insira o número: ");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine($"Quantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de números ímpares: {impares}");
        }
    }
}
