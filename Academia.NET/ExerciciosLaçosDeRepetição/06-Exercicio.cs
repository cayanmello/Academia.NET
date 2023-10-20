using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição
{
    internal class _06_Exercicio
    {
        public static void loop()
        {
            //6.Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações
            //aplicadas para aquela turma.Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final
            //(média das notas das avaliações).

            Console.Write("Digite o número de alunos na turma: ");
            int numeroDeAlunos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de avaliações aplicadas: ");
            int numeroDeAvaliacoes = int.Parse(Console.ReadLine());

            double somaDasNotas = 0;

            for (int index = 1; index <= numeroDeAlunos; index++)
            {
                double somaDasNotasDoAluno = 0;
                for (int jndex = 1; jndex <= numeroDeAvaliacoes; jndex++)
                {
                    Console.Write($"Digite a nota da avaliação {jndex} para o aluno {index}: ");
                    double nota = Convert.ToDouble(Console.ReadLine());
                    somaDasNotasDoAluno += nota;
                }

                double mediaDoAluno = somaDasNotasDoAluno / numeroDeAvaliacoes;
                Console.WriteLine($"A nota final do aluno {index} é: {mediaDoAluno}");
                somaDasNotas += mediaDoAluno;
            }

            double mediaDaTurma = somaDasNotas / numeroDeAlunos;
            Console.WriteLine($"A média da turma é: {mediaDaTurma}");
        }
    }
}
