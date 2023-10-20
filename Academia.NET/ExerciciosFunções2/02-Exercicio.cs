using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções2
{
    internal class _02_Exercicio
    {
        public static void funcoes2()
        {
            //2 - Escreva uma função chamada CalcularMedia que recebe um vetor de números, a informação se o usuário deseja escolher os pares ou os impares,
            //    e retorna a média dos valores conforme a escolha do usuário.


            Console.WriteLine("Digite a quantidade de números que deseja inserir:");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Calcular média dos números pares");
            Console.WriteLine("2 - Calcular média dos números ímpares");
            int escolha = int.Parse(Console.ReadLine());

            double media = CalcularMedia(numeros, escolha);
            Console.WriteLine($"A média dos números é: {media}");
        }

        static double CalcularMedia(int[] numeros, int escolha)
        {
            int soma = 0;
            int contador = 0;

            foreach (int numero in numeros)
            {
                if ((escolha == 1 && numero % 2 == 0) || (escolha == 2 && numero % 2 != 0))
                {
                    soma += numero;
                    contador++;
                }
            }

            if (contador > 0)
            {
                return (double)soma / contador;
            }
            else
            {
                Console.WriteLine("Nenhum número correspondente foi encontrado.");
                return 0;
            }
        }
    }
}
