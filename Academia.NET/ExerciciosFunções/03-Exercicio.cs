using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções
{
    internal class _03_Exercicio
    {
        public static void funcoes()
        {
            //3) Desenvolva uma função que calcule a média de três números fornecidos como argumentos.

            Console.WriteLine("Digite três números: ");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double resultado = media(a, b, c);
            Console.WriteLine($"A média dos três números são: {resultado}");

            static double media(double a, double b, double c)
            {
                return (a + b + c) / 3;
            }
        }
    }
}
