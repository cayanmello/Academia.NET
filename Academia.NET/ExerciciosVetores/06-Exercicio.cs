using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _06_Exercicio
    {
        public static void vetores()
        {
            //6.Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura.Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

            int tamanho = 10;
            int[] numeros = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Números na ordem contrária:");
            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.Write($"{numeros[i]} ");
            }

            Console.ReadLine();
        }
    }
}
