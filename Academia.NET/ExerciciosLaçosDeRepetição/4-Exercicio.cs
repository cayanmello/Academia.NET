using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição
{
    internal class _4_Exercicio
    {
        public static void loop()
        {
            //4.Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
            //elevado na y sem utilizar a função pow.

            Console.WriteLine("Digite o valor de X e Y e iremos calcular a potência de X elevado a Y");

            Console.Write("Digite o valor de X: ");
            int x = int.Parse(Console.ReadLine());

            int resultado = 1;

            Console.Write("Digite o valor de Y: ");
            int y = int.Parse(Console.ReadLine());

            for (int index = 0; index < y; index++)
            {
                resultado *= x;
            }
            Console.WriteLine($"O resultado de {x} elevado a {y} é: {resultado}");
        }
    }
}
