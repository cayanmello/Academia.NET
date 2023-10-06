using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _12_Exercicio
    {
        public static void selecao()
        {
            //12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e
            //número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo - se que ele ganha
            //R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
            //armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
            //No final do processamento, exibir o salário total e o salário excedente do operário.

            Console.Write("Digite o código do operário: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            int numeroHoras = int.Parse(Console.ReadLine());

            const double salarioPorHora = 10.0;
            const double salarioExtraPorHora = 20.0;
            const int limiteHoras = 50;

            double salario = numeroHoras <= limiteHoras ? numeroHoras * salarioPorHora : limiteHoras * salarioPorHora;
            double extra = 0.0;

            if (numeroHoras > limiteHoras)
            {
                extra = (numeroHoras - limiteHoras) * salarioExtraPorHora;
            }

            double salarioTotal = salario + extra;

            Console.WriteLine($"Salário total do operário (R$): {salarioTotal:F2}");
            Console.WriteLine($"Salário excedente do operário (R$): {extra:F2}");
        }
    }
}
