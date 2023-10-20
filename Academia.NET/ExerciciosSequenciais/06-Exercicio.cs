using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosSequenciais
{
    internal class _06_Exercicio
    {
        public static void sequenciais()
        {
            //6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
            //de IPI(única) a ser acrescentada.

            Console.Write("Digite o código do parafuso A ");
            int codigoA = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de peças do do parafuso A ");
            int qtdPecasA = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário de cada parafuso A ");
            int valUnitA = int.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de IPI(única) do parafuso A ");
            double ipiA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o código do parafuso B ");
            int codigoB = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de peças do do parafuso B ");
            int qtdPecasB = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário de cada parafuso B ");
            int valUnitB = int.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de IPI(única) do parafuso B ");
            double ipiB = Convert.ToDouble(Console.ReadLine());

            double totalA = qtdPecasA * valUnitA * (1 + ipiA / 100);
            double totalB = qtdPecasB * valUnitB * (1 + ipiB / 100);

            Console.WriteLine($"Total para parafuso A (código {codigoA}): R${totalA}");
            Console.WriteLine($"Total para parafuso B (código {codigoB}): R${totalB}");

            Console.ReadKey();
        }
    }
}
