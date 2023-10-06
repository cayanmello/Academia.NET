using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _11_Exercicio
    {
        public static void loop2()
        {
            //11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
            //a média aritmética da turma e a quantidade de alunos da turma.
            //Usar - 1 para encerrar a leitura.

            int nota;
            int contador = 0;
            int somaNotas = 0;
            int notaMaisAlta = int.MinValue;
            int notaMaisBaixa = int.MaxValue;

            Console.WriteLine("Digite as notas dos alunos. Para encerrar, digite -1.");

            while (true)
            {
                Console.Write("Digite a nota do aluno: ");
                nota = int.Parse(Console.ReadLine());

                if (nota == -1)
                {
                    break;
                }

                contador++;
                somaNotas += nota;

                if (nota > notaMaisAlta)
                {
                    notaMaisAlta = nota;
                }

                if (nota < notaMaisBaixa)
                {
                    notaMaisBaixa = nota;
                }
            }

            if (contador > 0)
            {
                double media = (double)somaNotas / contador;
                Console.WriteLine($"Nota mais alta: {notaMaisAlta}");
                Console.WriteLine($"Nota mais baixa: {notaMaisBaixa}");
                Console.WriteLine($"Média da turma: {media:F2}");
                Console.WriteLine($"Quantidade de alunos: {contador}");
            }
            else
            {
                Console.WriteLine("Nenhuma nota foi inserida.");
            }
        }
    }
}
