using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _15_Exercicio
    {
        public static void vetores()
        {
            //15.Faça um programa em C# que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem.
            //Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo.
            //Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

            int tamanho = 20;
            int[] vetor1 = new int[tamanho];
            int[] vetor2 = new int[tamanho];

            Console.WriteLine("Digite 20 elementos inteiros:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamanho; i++)
            {
                vetor2[i] = vetor1[tamanho - 1 - i];
            }

            Console.Write("Vetor 1: ");
            MostrarVetor(vetor1);

            Console.Write("Vetor 2 (Ordem invertida): ");
            MostrarVetor(vetor2);

            Console.ReadLine();
        }

        static void MostrarVetor(int[] vetor)
        {
            foreach (int elemento in vetor)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
        }
    }
}
