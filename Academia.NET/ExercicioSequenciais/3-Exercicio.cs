using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExercicioSequenciais
{
    internal class _3_Exercicio
    {
        public static void sequenciais()
        {
            //3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
            //si os valores de duas variáveis A e B.

            int A, B, temp;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            temp = A;
            A = B;
            B = temp;

            Console.WriteLine($"Após a troca, o valor de A é: {A}");
            Console.WriteLine($"Após a troca, o valor de B é: {B}");

            Console.ReadKey();
        }
    }
}
