using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _17_Exercicio
    {
        public static void loop2()
        {
            //17.Apresentar os quadrados dos números inteiros de 15 a 200.

            Console.WriteLine("Quadrados dos números inteiros de 15 a 200:");

            for (int index = 15; index <= 200; index++)
            {
                int quadrado = index * index;
                Console.WriteLine($"O quadrado de {index} é {quadrado}");
            }
        }
    }
}
