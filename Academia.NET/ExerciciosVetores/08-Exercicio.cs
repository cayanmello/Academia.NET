using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _08_Exercicio
    {
        public static void vetores()
        {
            //8.Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
            //a.lê: | 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
            //b.escreve: | 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .

            int tamanho = 30;
            double[] numeros = new double[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Posições dos números menores que zero: ");
            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.Write($"{i + 1} ");
                }
            }

            Console.ReadLine();
        }
    }
}
