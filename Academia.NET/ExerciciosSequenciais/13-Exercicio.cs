using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosSequenciais
{
    internal class _13_Exercicio
    {
        public static void sequenciais()
        {
            //13) Uma loja vende bicicletas com um acréscimo de 50 % sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais,
            //mais uma comissão de 15 % sobre o preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo,
            //o preço de custo de cada bicicleta e o número de bicicletas vendidas pelo vendedor, calcule e mostre: o salário do empregado.

            double salarioMinimo, precoCustoBicicleta, numeroBicicletas;

            Console.Write("Digite o valor do salário mínimo: R$");
            salarioMinimo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o preço de custo da bicicleta: R$");
            precoCustoBicicleta = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
            numeroBicicletas = Convert.ToDouble(Console.ReadLine());

            double salarioEmpregado = 2 * salarioMinimo + (0.15 * precoCustoBicicleta * numeroBicicletas);

            Console.WriteLine($"O salário do empregado é: R${salarioEmpregado:F2}");
        }
    }
}
