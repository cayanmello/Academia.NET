using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _13_Exercicio
    {
        public static void vetores()
        {
            //13.Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8.O vetor terá no máximo 100 posições.
            //Sair do programa quando for digitado - 1 ou quando atingir o máximo de posições do vetor.

            const int tamanho = 100;
            int[] vetor = new int[tamanho];
            int contador2 = 0;
            int contador4 = 0;
            int contador8 = 0;
            int posicao = 0;

            Console.WriteLine("Digite números inteiros e positivos para preencher o vetor.");
            Console.WriteLine("Digite -1 para sair ou atingir o máximo de posições (100).");

            while (posicao < tamanho)
            {
                Console.Write($"Digite o número na posição {posicao + 1}: ");
                vetor[posicao] = int.Parse(Console.ReadLine());

                if (vetor[posicao] == -1)
                {
                    break;
                }

                if (vetor[posicao] == 2)
                {
                    contador2++;
                }
                else if (vetor[posicao] == 4)
                {
                    contador4++;
                }
                else if (vetor[posicao] == 8)
                {
                    contador8++;
                }

                posicao++;
            }

            Console.WriteLine($"Número 2 aparece {contador2} vez(es).");
            Console.WriteLine($"Número 4 aparece {contador4} vez(es).");
            Console.WriteLine($"Número 8 aparece {contador8} vez(es).");

            Console.ReadLine();
        }
    }
}
