using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções
{
    internal class _04_Exercicio
    {
        public static void funcoes()
        {
            //4) Escreva uma função que calcule o fatorial de um número inteiro positivo.

            Console.Write("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            long resultado = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é {resultado}");
        }

        static long CalcularFatorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }
            else
            {
                long fatorial = 1;
                for (int i = 2; i <= numero; i++)
                {
                    fatorial *= i;
                }
                return fatorial;
            }
        }
    }
}
