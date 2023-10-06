using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _4_Exercicio
    {
        public static void selecao()
        {
            //4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            //Mostrar na tela qual dos professores tem o maior salário total.

            Console.Write("Digite a quantidade de horas por aula do primeiro professor: ");
            int horasAula1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor por hora do primeiro professor: ");
            double valorHora1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas por aula do segundo professor: ");
            int horasAula2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor por hora do segundo professor: ");
            double valorHora2 = double.Parse(Console.ReadLine());

            double salario1 = horasAula1 * valorHora1;
            double salario2 = horasAula2 * valorHora2;

            if (salario1 > salario2)
            {
                Console.WriteLine("O primeiro professor tem o maior salário total: R$ " + salario1);
            }
            else if (salario2 > salario1)
            {
                Console.WriteLine("O segundo professor tem o maior salário total: R$ " + salario2);
            }
            else
            {
                Console.WriteLine("Os professores têm o mesmo salário total: R$ " + salario1);
            }
        }
    }
}
