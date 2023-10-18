using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções
{
    internal class _1_Exercicio
    {
        public static void funcoes()
        {
            //1) Fazer uma calculadora das 4 operações(soma, subtração, multiplicação e divisão) Para isso, precisaremos aceitar números com vírgula.

            Console.WriteLine("Digite dois números: ");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());

            double resultadoSum = sum(a, b);
            Console.WriteLine($"A  soma de {a} + {b} = {resultadoSum}");

            double resultadoSub = sub(a, b);
            Console.WriteLine($"A  subtração de {a} - {b} = {resultadoSub}");

            double resultadoDiv = div(a, b);
            Console.WriteLine($"A  divisão de {a} / {b} = {resultadoDiv}");

            double resultadoMulti = multi(a, b);
            Console.WriteLine($"A  multiplicação de {a} * {b} = {resultadoMulti}");

            static double sum(double a, double b)
            {
                return a + b;
            }

            static double sub(double a, double b)
            {
                return a - b;
            }

            static double div(double a, double b)
            {
                return a / b;
            }

            static double multi(double a, double b)
            {
                return a * b;
            }
        }
    }
}
