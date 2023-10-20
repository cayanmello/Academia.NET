using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição
{
    internal class _07_Exercicio
    {
        public static void loop()
        {
            //7.Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
            //um usuário. Apresente o resultado.

            int numerosPares = 0;
            int numerosImpares = 0;

            for (int index = 1; index <= 20; index++)
            {
                Console.Write($"Digite o {index}º número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    numerosPares++;
                }
                else
                {
                    numerosImpares++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {numerosPares}");
            Console.WriteLine($"Quantidade de números ímpares: {numerosImpares}");
        }
    }
}
