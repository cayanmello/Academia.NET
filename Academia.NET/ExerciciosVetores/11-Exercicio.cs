using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _11_Exercicio
    {
        public static void vetores()
        {
            //11.Escreva um programa que leia valores em um vetor de 5 posições.
            //Escrever os elementos do vetor e após escrever os elementos na ordem inversa.


            int tamanho = 5;
            int[] numeros = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números na ordem contrária:");
            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.Write($"{numeros[i]} ");
            }

            Console.ReadLine();
        }
    }
}
