using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _1_Exercicio
    {
        public static void selecao()
        {
            //1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2;
            //Teste se a base ou a altura digitada não foi igual a zero.

            Console.WriteLine("Calculando a área do triângulo");
            Console.WriteLine("------------------------------");

            Console.Write("Qual o valor da base do triângulo? ");
            int @base = int.Parse(Console.ReadLine());
            Console.Write("Qual valor da altura do triângulo? ");
            int altura = int.Parse(Console.ReadLine());
            int resultado = (@base * altura) / 2;
            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}
