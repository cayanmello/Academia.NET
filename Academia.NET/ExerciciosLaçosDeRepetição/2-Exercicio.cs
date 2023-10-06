using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição
{
    internal class _2_Exercicio
    {
        public static void loop()
        {
            //2.Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

            double maiorNumero = double.MinValue;

            for (int index = 0; index < 10; index++)
            {
                Console.Write("Digite um número: ");
                double numero = double.Parse(Console.ReadLine());

                if (numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }

            Console.WriteLine("O maior número digitado é: " + maiorNumero);
        }
    }
}
