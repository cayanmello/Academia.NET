using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _12_Exercicio
    {
        public static void loop2()
        {
            //12.Apresentar o total da soma dos cem primeiros números inteiros.

            int soma = 0;

            for (int index = 1; index <= 100; index++)
            {
                soma += index;
            }

            Console.WriteLine($"A soma dos primeiros 100 números inteiros é: {soma}");
        }
    }
}
