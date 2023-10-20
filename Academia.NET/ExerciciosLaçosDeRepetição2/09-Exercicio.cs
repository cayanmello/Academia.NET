using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _09_Exercicio
    {
        public static void loop2()
        {
            //9.Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram
            //o zoológico num determinado dia, imprimindo:
            //Quantas pessoas tem entre 1 e 3 filhos.
            //Quantas pessoas tem entre 4 e 7 filhos.
            //Quantas pessoas tem mais de 8 filhos.
            //Quantas pessoas não tem filhos.

            int pessoasCom1a3Filhos = 0;
            int pessoasCom4a7Filhos = 0;
            int pessoasComMaisDe8Filhos = 0;
            int pessoasSemFilhos = 0;

            for (int index = 1; index <= 30; index++)
            {
                Console.Write($"Digite a quantidade de filhos da pessoa {index}: ");
                int numeroFilhos = int.Parse(Console.ReadLine());

                if (numeroFilhos >= 1 && numeroFilhos <= 3)
                {
                    pessoasCom1a3Filhos++;
                }
                else if (numeroFilhos >= 4 && numeroFilhos <= 7)
                {
                    pessoasCom4a7Filhos++;
                }
                else if (numeroFilhos > 8)
                {
                    pessoasComMaisDe8Filhos++;
                }
                else if (numeroFilhos == 0)
                {
                    pessoasSemFilhos++;
                }
            }

            Console.WriteLine($"Pessoas com 1 a 3 filhos: {pessoasCom1a3Filhos}");
            Console.WriteLine($"Pessoas com 4 a 7 filhos: {pessoasCom4a7Filhos}");
            Console.WriteLine($"Pessoas com mais de 8 filhos: {pessoasComMaisDe8Filhos}");
            Console.WriteLine($"Pessoas sem filhos: {pessoasSemFilhos}");
        }
    }
}
