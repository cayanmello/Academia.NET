using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções
{
    internal class _09_Exercicio
    {
        public static void funcoes()
        {
            //9) Escrever um programa com uma função que receba por parâmetro dois números(n1 e n2)
            //e retorna a soma dos números inteiros que existem entre n1 e n2(inclusive ambos).
            //Apresente o resultado na main.

            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = SomaNumerosInteirosEntre(n1, n2);
            Console.WriteLine($"A soma dos números inteiros entre {n1} e {n2} é: {resultado}");
        }

        static int SomaNumerosInteirosEntre(int n1, int n2)
        {
            int soma = 0;
            for (int i = Math.Min(n1, n2); i <= Math.Max(n1, n2); i++)
            {
                soma += i;
            }
            return soma;
        }
    }
}
