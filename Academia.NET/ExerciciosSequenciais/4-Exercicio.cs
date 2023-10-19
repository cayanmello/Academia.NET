using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosSequenciais
{
    internal class _4_Exercicio
    {
        public static void sequenciais()
        {
            //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            Console.Write("Digite a data no formato DDMMAAAA: ");
            string data = Console.ReadLine();

            // Extrai o dia, mês e ano da entrada do usuário
            int dia = int.Parse(data.Substring(0, 2));
            int mes = int.Parse(data.Substring(2, 2));
            int ano = int.Parse(data.Substring(4, 4));

            // Imprime a data no formato AAAAMMDD
            Console.WriteLine($"AAAAMMDD: {ano}{mes:00}{dia:00}");

            // Imprime a data no formato AAMMDD
            Console.WriteLine($"AAMMDD: {ano % 100:00}{mes:00}{dia:00}");
        }
    }
}
