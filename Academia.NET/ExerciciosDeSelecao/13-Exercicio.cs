using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _13_Exercicio
    {
        public static void selecao()
        {
            //13 - Tendo como dado de entrada a altura(h) de uma pessoa, construa um programa no VS que calcule
            //seu peso ideal, utilizando as seguintes fórmulas:
            //Para homens: (72.7 * h) - 50
            //Para mulheres: (62.1 * h) - 44.7

            Console.Write("Digite a altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha o gênero (M para masculino, F para feminino): ");
            char genero = Console.ReadKey().KeyChar;

            double pesoIdeal = 0.0;

            if (genero == 'M' || genero == 'm')
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else if (genero == 'F' || genero == 'f')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine("Opção de gênero inválida.");
                return;
            }

            Console.WriteLine($"\nO peso ideal para uma pessoa com {altura}m de altura é: {pesoIdeal:F2} kg.");
        }
    }
}
