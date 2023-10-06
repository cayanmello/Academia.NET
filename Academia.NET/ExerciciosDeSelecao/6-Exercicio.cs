using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _6_Exercicio
    {
        public static void selecao()
        {
            //6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
            //O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
            //O cálculo do imc = peso / (altura * altura)

            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine().ToUpper();

            Console.Write("Digite a altura da pessoa (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da pessoa (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            // Calcular o IMC
            double imc = (altura * altura) / peso;

            string situacao = "";
            if (imc < 18)
            {
                situacao = "baixo peso";
            }
            else if (imc >= 18 && imc < 25)
            {
                situacao = "peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                situacao = "sobrepeso";
            }
            else if (imc >= 30 && imc < 35)
            {
                situacao = "obesidade";
            }
            else
            {
                situacao = "obesidade grau sério";
            }

            Console.WriteLine($"O IMC de {nome} é {imc:F2}, o que indica {situacao}.");
        }
    }
}
