using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _05_Exercicio
    {
        public static void selecao()
        {
            //5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            //se a média das duas notas for maior ou igual a 7, 0

            Console.Write("Digite a nota da primeira prova do aluno: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova do aluno: ");
            int nota2 = int.Parse(Console.ReadLine());

            int media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
