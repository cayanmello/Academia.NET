using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _7_Exercicio
    {
        public static void loop2()
        {
            //7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
            //A cada solicitação, teste se o usuário informou um valor válido. 
            //Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            //informe que ele está incorreto e saia do programa em VS.
            //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            //informe que está errada e saia.Se estiver correta, solicite o salário.
            //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            //Se estiver correto, mostre todos os valores lidos.

            string nome;
            int idade;
            double salario;

            while (true)
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nome inválido. Tente novamente.");
                }
            }

            while (true)
            {
                Console.Write("Digite a idade: ");
                if (int.TryParse(Console.ReadLine(), out idade) && idade > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Idade inválida. Tente novamente.");
                }
            }

            while (true)
            {
                Console.Write("Digite o salário: ");
                if (double.TryParse(Console.ReadLine(), out salario) && salario > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Salário inválido. Tente novamente.");
                }
            }

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Salário: R${salario}");
        }
    }
}
