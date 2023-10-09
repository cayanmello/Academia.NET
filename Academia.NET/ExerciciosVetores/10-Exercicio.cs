using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _10_Exercicio
    {
        public static void vetores()
        {
            //10.Escreva um algoritmo que leia um vetor inteiro de 20 posições.
            //Crie um segundo vetor, substituindo os valores nulos por 2.
            //Mostre os vetores lidos e o vetor resultado.

            int tamanho = 20;
            int[] vetorOriginal = new int[tamanho];
            int[] vetorResultado = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o valor para a posição {i + 1}: ");
                vetorOriginal[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamanho; i++)
            {
                if (vetorOriginal[i] == 0)
                {
                    vetorResultado[i] = 2;
                }
                else
                {
                    vetorResultado[i] = vetorOriginal[i];
                }
            }

            Console.WriteLine("Vetor Original:");
            MostrarVetor(vetorOriginal);

            Console.WriteLine("\nVetor Resultado:");
            MostrarVetor(vetorResultado);

            Console.ReadLine();
        }

        static void MostrarVetor(int[] vetor)
        {
            foreach (int elemento in vetor)
            {
                Console.Write($"{elemento} ");
            }
        }
    }
}
