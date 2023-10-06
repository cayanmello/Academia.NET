using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _15_Exercicio
    {
        public static void loop2()
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 * 2 + nota2 * 1 + nota3 * 2 + nota4 * 4) / 9;

            if (media >= 7.0)
            {
                Console.WriteLine($"Média: {media:F2}");
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine($"Média: {media:F2}");
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
