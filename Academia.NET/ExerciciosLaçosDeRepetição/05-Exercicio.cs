using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição
{
    internal class _05_Exercicio
    {
        public static void loop()
        {
            //5.Escreva um algoritmo para calcular o fatorial de um número.

            Console.Write("Digite um número inteiro positivo para calcular o fatorial: ");
            int numero = int.Parse(Console.ReadLine());

            long fatorial = 1;

            for (int index = 2; index <= numero; index++)
            {
                fatorial *= index;
            }

            Console.WriteLine($"O fatorial de {numero} é {fatorial}");
        }
    }
}
