using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _8_Exercicio
    {
        public static void selecao()
        {
            //8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            //Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
            //E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % do
            //total de vendas.

            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o salário base do funcionário:");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas do funcionário:");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            double bonus = 0;

            if (totalVendas > 500)
            {
                bonus += totalVendas * 0.05;

                if (totalVendas > 1000)
                {
                    bonus += totalVendas * 0.07;

                    if (totalVendas > 5000)
                    {
                        bonus += totalVendas * 0.10;
                    }
                }
            }

            double salarioFinal = salarioBase + bonus;
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário base: R$ {salarioBase}");
            Console.WriteLine($"Bônus por vendas: R$ {bonus}");
            Console.WriteLine($"Salário final: R$ {salarioFinal}");
        }
    }
}
