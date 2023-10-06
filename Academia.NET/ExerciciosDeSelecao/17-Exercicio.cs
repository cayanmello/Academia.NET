using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _17_Exercicio
    {
        public static void selecao()
        {
            //17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c), e então diga se esses lados podem ou não formar um triangulo.
            //    Para que os lados formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados
            //    Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

            Console.Write("Digite o tamanho do lado a: ");
            double ladoA = double.Parse(Console.ReadLine());

            Console.Write("Digite o tamanho do lado b: ");
            double ladoB = double.Parse(Console.ReadLine());

            Console.Write("Digite o tamanho do lado c: ");
            double ladoC = double.Parse(Console.ReadLine());

            if (PodeFormarTriangulo(ladoA, ladoB, ladoC))
            {
                Console.WriteLine("Os lados podem formar um triângulo.");

                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("O triângulo é equilátero (todos os lados são iguais).");
                }
                else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                {
                    Console.WriteLine("O triângulo é isósceles (dois lados são iguais).");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno (todos os lados são diferentes).");
                }
            }
            else
            {
                Console.WriteLine("Os lados não podem formar um triângulo.");
            }

            static bool PodeFormarTriangulo(double a, double b, double c)
            {
                return a + b > c && a + c > b && b + c > a;
            }
        }
    }
}
