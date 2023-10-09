using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _7_Exercicio
    {
        public static void vetores()
        {
            //7.Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

            int tamanho = 10;
            int[] numeros = new int[tamanho];
            int[] numerosPares = new int[tamanho];
            int[] numerosImpares = new int[tamanho];
            int contadorPares = 0;
            int contadorImpares = 0;

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    numerosPares[contadorPares] = numeros[i];
                    contadorPares++;
                }
                else
                {
                    numerosImpares[contadorImpares] = numeros[i];
                    contadorImpares++;
                }
            }

            Console.WriteLine("Números pares:");
            for (int i = 0; i < contadorPares; i++)
            {
                Console.Write($"{numerosPares[i]} ");
            }

            Console.WriteLine("\nNúmeros ímpares:");
            for (int i = 0; i < contadorImpares; i++)
            {
                Console.Write($"{numerosImpares[i]} ");
            }

            Console.ReadLine();
        }
    }
}
