using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _20_Exercicio
    {
        public static void selecao()
        {
            //20 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada(metros, centímetros, polegadas ou pés) e uma unidade de
            //medida de saída usando um menu com o comando switch case.O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse
            //valor para a unidade de saída selecionada.

            Console.WriteLine("Selecione a unidade de medida de entrada:");
            Console.WriteLine("1. Metros");
            Console.WriteLine("2. Centímetros");
            Console.WriteLine("3. Polegadas");
            Console.WriteLine("4. Pés");

            int unidadeEntrada = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a unidade de medida de saída:");
            Console.WriteLine("1. Metros");
            Console.WriteLine("2. Centímetros");
            Console.WriteLine("3. Polegadas");
            Console.WriteLine("4. Pés");

            int unidadeSaida = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de entrada: ");
            double valorEntrada = double.Parse(Console.ReadLine());

            double valorConvertido = 0;

            switch (unidadeEntrada)
            {
                case 1: // Metros
                    valorConvertido = valorEntrada;
                    break;
                case 2: // Centímetros para Metros
                    valorConvertido = valorEntrada / 100;
                    break;
                case 3: // Polegadas para Metros
                    valorConvertido = valorEntrada * 0.0254;
                    break;
                case 4: // Pés para Metros
                    valorConvertido = valorEntrada * 0.3048;
                    break;
                default:
                    Console.WriteLine("Opção inválida de unidade de entrada.");
                    return;
            }

            switch (unidadeSaida)
            {
                case 1: // Metros
                    valorConvertido = valorConvertido;
                    break;
                case 2: // Metros para Centímetros
                    valorConvertido *= 100;
                    break;
                case 3: // Metros para Polegadas
                    valorConvertido /= 0.0254;
                    break;
                case 4: // Metros para Pés
                    valorConvertido /= 0.3048;
                    break;
                default:
                    Console.WriteLine("Opção inválida de unidade de saída.");
                    return;
            }

            Console.WriteLine("Valor convertido: " + valorConvertido);
        }
    }
}
