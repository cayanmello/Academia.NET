using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _15_Exercicio
    {
        public static void selecao()
        {
            //15 - Faça um programa para uma loja de tintas.O programa deverá pedir o tamanho em metros quadrados
            //da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
            //e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
            //Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

            const int coberturaPorLata = 54;
            const double precoPorLata = 80.00;

            Console.Write("Digite o tamanho da área a ser pintada (em metros quadrados): ");
            double areaEmMetrosQuadrados = Convert.ToDouble(Console.ReadLine());

            double litrosNecessarios = areaEmMetrosQuadrados / 3;

            int latasNecessarias = (int)Math.Ceiling(litrosNecessarios / coberturaPorLata);

            double precoTotal = latasNecessarias * precoPorLata;

            Console.WriteLine($"Quantidade de latas de tinta necessárias: {latasNecessarias}");
            Console.WriteLine($"Preço total: R$ {precoTotal:F2}");
        }
    }
}
