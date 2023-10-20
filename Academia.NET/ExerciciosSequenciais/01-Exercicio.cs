using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosSequenciais
{
    internal class _01_Exercicio
    {
        public static void sequenciais()
        {
            //1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double media = (numero1 + numero2) / 2;

            Console.WriteLine($"A média aritmética de {numero1} e {numero2} é: {media}");

            Console.ReadKey();
        }
    }
}
