using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _16_Exercicio
    {
        public static void loop2()
        {
            //16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
            //multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
            //(N * 3; N * 3 * 3; N * 3 * 3 * 3; etc).

            Console.Write("Digite um número menor ou igual a 50: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 50 && numero > 0)
            {
                int resultado = numero;

                while (resultado < 250)
                {
                    resultado *= 3;
                    Console.WriteLine(resultado);
                }
            }
            else
            {
                Console.WriteLine("O número deve ser menor ou igual a 50 e maior que zero.");
            }
        }
    }
}
