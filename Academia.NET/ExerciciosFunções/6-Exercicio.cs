using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções
{
    internal class _6_Exercicio
    {
        public static void funcoes()
        {
            //6) Escreva uma função que calcule a média de um vetor de 10 números.


            int[] vetorDeNumeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double media = CalcularMedia(vetorDeNumeros);
            Console.WriteLine("A média dos números é: " + media);
        }

        static double CalcularMedia(int[] vetor)
        {
            if (vetor.Length != 10)
            {
                throw new ArgumentException("O vetor deve conter exatamente 10 números.");
            }

            double soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            double media = soma / vetor.Length;
            return media;
        }
    }
}
