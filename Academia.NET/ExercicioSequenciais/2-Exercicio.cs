using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExercicioSequenciais
{
    internal class _2_Exercicio
    {
        public static void sequenciais()
        {
            //2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o quarto número: ");
            double numero4 = Convert.ToDouble(Console.ReadLine());

            double media = (numero1 + numero2 + numero3 + numero4) / 4;

            Console.WriteLine($"A média aritmética de {numero1}, {numero2}, {numero3} e {numero4} é: {media}");

            Console.ReadKey();
        }
    }
}
