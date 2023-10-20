using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _06_Exercicio
    {
        public static void loop2()
        {
            //6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            //ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
            //Ao final, mostre a idade digitada.

            int idade;

            do
            {
                Console.Write("Digite a idade (deve ser maior que zero): ");
                if (int.TryParse(Console.ReadLine(), out idade) && idade > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Idade inválida. Tente novamente.");
                }
            } while (true);

            Console.WriteLine($"Idade digitada: {idade}");
        }
    }
}
