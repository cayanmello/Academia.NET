using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _12_Exercicio
    {
        public static void vetores()
        {
            //12.Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor.
            //Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

            int tamanho = 10;
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite um número para verificar se existe no vetor: ");
            int numeroProcurado = int.Parse(Console.ReadLine());

            bool encontrado = false;
            Console.Write("Número encontrado e está na posição: ");
            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] == numeroProcurado)
                {
                    Console.Write($"{i + 1} ");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }

            Console.ReadLine();
        }
    }
}
