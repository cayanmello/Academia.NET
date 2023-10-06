using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _13_Exercicio
    {
        public static void loop2()
        {
            //13.Elaborar um programa que apresente o somatório dos valores pares existentes
            //entre 1 e 500.

            int soma = 0;

            for (int index = 1; index <= 500; index++)
            {
                if (index % 2 == 0)
                {
                    soma += index;
                }
            }

            Console.WriteLine($"O somatório dos valores pares entre 1 e 500 é: {soma}");
        }
    }
}
