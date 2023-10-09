using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _14_Exercicio
    {
        public static void vetores()
        {
            //14.Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números
            //.Se o código for zero, termine o algoritmo.Se o código for 1, mostre o vetor na ordem em que foi lido.
            //Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

            const int tamanho = 50;
            int[] vetor = new int[tamanho];
            int codigo;

            Console.Write("Digite o código numérico (0 para sair, 1 para mostrar na ordem, 2 para mostrar na ordem inversa): ");
            codigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número na posição {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            switch (codigo)
            {
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;
                case 1:
                    Console.WriteLine("Vetor na ordem em que foi lido:");
                    MostrarVetor(vetor);
                    break;
                case 2:
                    Console.WriteLine("Vetor na ordem inversa:");
                    MostrarVetorInverso(vetor);
                    break;
                default:
                    Console.WriteLine("Código inválido.");
                    break;
            }

            Console.ReadLine();
        }

        static void MostrarVetor(int[] vetor)
        {
            foreach (int numero in vetor)
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine();
        }

        static void MostrarVetorInverso(int[] vetor)
        {
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();
        }
    }
}
