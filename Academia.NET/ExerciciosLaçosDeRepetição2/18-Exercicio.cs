using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _18_Exercicio
    {
        public static void loop2()
        {
            //18.Elaborar um programa que apresente o valor de uma potência de uma base qualquer
            //elevada a um expoente qualquer, ou seja, NM.

            Console.WriteLine("Calculadora de Potência");

            Console.Write("Digite a base (N): ");
            double baseNumero = double.Parse(Console.ReadLine());

            Console.Write("Digite o expoente (M): ");
            double expoente = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(baseNumero, expoente);

            Console.WriteLine($"O resultado de {baseNumero}^{expoente} é: {resultado}");
        }
    }
}
