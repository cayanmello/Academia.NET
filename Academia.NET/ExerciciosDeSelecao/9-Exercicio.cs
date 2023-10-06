using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _9_Exercicio
    {
        public static void selecao()
        {
            //9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            //diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            //Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.

            Console.WriteLine("Por favor, insira os 3 valores de glicemia em jejum:");

            Console.Write("Valor da primeira consulta do dia: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Valor segunda consulta do dia: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Valor da terceira consulta do dia: ");
            int valor3 = int.Parse(Console.ReadLine());

            if (valor1 < 65)
            {
                Console.WriteLine("Atenção: O valor diário " + valor1 + " está abaixo de 65, o que indica risco de hipoglicemia.");
            }
            else if (valor1 > 250)
            {
                Console.WriteLine("Atenção: O valor diário " + valor1 + " está acima de 250, o que indica risco de hiperglicemia.");
            }

            if (valor2 < 65)
            {
                Console.WriteLine("Atenção: O valor diário " + valor2 + " está abaixo de 65, o que indica risco de hipoglicemia.");
            }
            else if (valor2 > 250)
            {
                Console.WriteLine("Atenção: O valor diário " + valor2 + " está acima de 250, o que indica risco de hiperglicemia.");
            }

            if (valor3 < 65)
            {
                Console.WriteLine("Atenção: O valor diário " + valor3 + " está abaixo de 65, o que indica risco de hipoglicemia.");
            }
            else if (valor3 > 250)
            {
                Console.WriteLine("Atenção: O valor diário " + valor3 + " está acima de 250, o que indica risco de hiperglicemia.");
            }
            else
            {
                Console.WriteLine("Análise concluída. Consulte um profissional de saúde para orientações adicionais.");
            }

            Console.ReadLine();
        }
    }
}
