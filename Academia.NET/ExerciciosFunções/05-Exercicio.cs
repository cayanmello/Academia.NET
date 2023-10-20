using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções
{
    internal class _05_Exercicio
    {
        public static void funcoes()
        {
            //5) Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.

            Console.Write("Digite a temperatura em graus Celsius: ");
            int tempCelsius = int.Parse(Console.ReadLine());
            double tempFahrenheit = ConverterParaFahrenheit(tempCelsius);
            Console.WriteLine($"{tempCelsius} graus Celsius são {tempFahrenheit} graus Fahrenheit.");
        }

        static double ConverterParaFahrenheit(double tempCelsius)
        {
            double temperaturaFahrenheit = tempCelsius * 9 / 5 + 32;
            return temperaturaFahrenheit;
        }
    }
}
