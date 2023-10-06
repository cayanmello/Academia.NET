using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _8_Exercicio
    {
        public static void loop2()
        {
            //8.Faça um programa em VS que solicite um numero inteiro.
            //Se o numero não for inteiro, solicite - o até que seja.após, informe se ele é par ou impar.
            //Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.


            char repetir;

            do
            {
                int numero;
                bool inputValido = false;

                do
                {
                    Console.Write("Digite um número inteiro: ");
                    string input = Console.ReadLine();

                    inputValido = int.TryParse(input, out numero);

                    if (!inputValido)
                    {
                        Console.WriteLine("Por favor, digite um número inteiro válido.");
                    }
                } while (!inputValido);

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero} é um número par.");
                }
                else
                {
                    Console.WriteLine($"{numero} é um número ímpar.");
                }

                Console.Write("Deseja repetir o programa (s/n)? ");
                repetir = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (repetir == 's' || repetir == 'S');
        }
    }
}
