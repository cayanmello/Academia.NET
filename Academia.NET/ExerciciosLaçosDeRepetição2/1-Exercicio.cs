using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _1_Exercicio
    {
        public static void loop2()
        {
            //1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            //Exemplo:
            //            Digite um número inteiro positivo: -8
            //Valor incorreto!
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            int numero;
            bool entradaValida = false;

            while (true)
            {
                Console.Write("Digite um número inteiro positivo: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero) && numero > 0)
                {
                    entradaValida = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Valor incorreto! Por favor, digite um número inteiro positivo.");
                }
            }

            Console.WriteLine($"Número digitado: {numero}");
            Console.Write("Números inteiros pares entre 1 e " + numero + ": ");

            for (int index = 2; index <= numero; index += 2)
            {
                Console.Write(index);

                if (index < numero - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
