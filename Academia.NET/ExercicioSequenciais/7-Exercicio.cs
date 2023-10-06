using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExercicioSequenciais
{
    internal class _7_Exercicio
    {
        public static void sequenciais()
        {
            //7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            //Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.

            Console.WriteLine("Digite o número do vendedor: ");
            int numeroVendedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário fixo do vendedor: ");
            double salarioFixo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas efetuadas pelo vendedor: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o percentual sobre o total de vendas que o vendedor ganha: ");
            double percentualComissao = Convert.ToDouble(Console.ReadLine());

            double salarioTotal = salarioFixo + (totalVendas * percentualComissao / 100);

            Console.WriteLine($"Número do vendedor: {numeroVendedor}");
            Console.WriteLine($"Salário total do vendedor: R${salarioTotal}");

            Console.ReadKey();
        }
    }
}
