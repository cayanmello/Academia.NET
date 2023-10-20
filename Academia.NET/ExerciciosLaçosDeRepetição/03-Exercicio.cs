using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição
{
    internal class _03_Exercicio
    {
        public static void loop()
        {
            //3.Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
            //x lido utilizando laços de repetição, e mostre na tela.


            Console.Write("Digite um valor para calcular a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int index = 1; index <= 10; index++)
            {
                int resultado = index * numero;
                Console.WriteLine(resultado);
            }
        }
    }
}
