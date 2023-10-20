using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _03_Exercicio
    {
        public static void selecao()
        {
            //3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

            int[] valores = new int[4];
            int soma = 0;

            for (int index = 0; index < 4; index++)
            {
                Console.Write($"Digite o {index + 1}º valor: ");
                valores[index] = Convert.ToInt32(Console.ReadLine());
                soma += valores[index];
            }

            double media = soma / 4.0;

            Console.WriteLine($"Média dos valores: {media}");

            Console.WriteLine("Valores superiores à média:");
            for (int index = 0; index < 4; index++)
            {
                if (valores[index] > media)
                {
                    Console.WriteLine(valores[index]);
                }
            }
        }
    }
}
