using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _19_Exercicio
    {
        public static void loop2()
        {
            //19.A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
            //coletando dados sobre o salário e número de filhos. A prefeitura deseja saber:

            //a) média do salário da população;
            //b) média do número de filhos;
            //c) maior salário;
            //d) percentual de pessoas com salário até R$ 100,00.
            //O final da leitura de dados se dará com a entrada de um salário negativo.

            double somaSalario = 0;
            int somaFilhos = 0;
            double maiorSalario = 0;
            int contadorSalarioAte100 = 0;
            int totalHabitantes = 0;

            Console.WriteLine("Informe os dados dos habitantes. Para encerrar, digite 'fim'.");

            while (true)
            {
                Console.Write("Salário (ou 'fim' para encerrar): ");
                string entradaSalario = Console.ReadLine();

                if (entradaSalario.ToLower() == "fim")
                {
                    break;
                }

                double salario;
                if (!double.TryParse(entradaSalario, out salario))
                {
                    Console.WriteLine("Entrada inválida para o salário. Tente novamente.");
                    continue;
                }

                Console.Write("Número de filhos: ");
                int numFilhos;
                if (!int.TryParse(Console.ReadLine(), out numFilhos))
                {
                    Console.WriteLine("Entrada inválida para o número de filhos. Tente novamente.");
                    continue;
                }

                somaSalario += salario;
                somaFilhos += numFilhos;

                if (salario > maiorSalario)
                {
                    maiorSalario = salario;
                }

                if (salario <= 100)
                {
                    contadorSalarioAte100++;
                }

                totalHabitantes++;
            }

            if (totalHabitantes > 0)
            {
                double mediaSalario = somaSalario / totalHabitantes;

                double mediaFilhos = (double)somaFilhos / totalHabitantes;

                double percentualSalarioAte100 = (double)contadorSalarioAte100 / totalHabitantes * 100;

                Console.WriteLine($"Média do salário da população: R$ {mediaSalario:F2}");
                Console.WriteLine($"Média do número de filhos: {mediaFilhos:F2}");
                Console.WriteLine($"Maior salário: R$ {maiorSalario:F2}");
                Console.WriteLine($"Percentual de pessoas com salário até R$ 100,00: {percentualSalarioAte100:F2}%");
            }
            else
            {
                Console.WriteLine("Nenhum dado foi inserido.");
            }
        }
    }
}
