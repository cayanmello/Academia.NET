using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _03_Exercicio
    {
        public static void vetores()
        {
            //3.Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

            int tamanho = 20;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Índices das posições com números primos:");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (primo(vetor[i]))
                {
                    Console.WriteLine($"Posição {i}: {vetor[i]}");
                }
            }

            Console.ReadLine();
        }

        static bool primo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
