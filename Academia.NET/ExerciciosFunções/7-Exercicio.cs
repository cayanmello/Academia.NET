using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções
{
    internal class _7_Exercicio
    {
        public static void funcoes()
        {
            //7) Crie uma função que determine se um número é primo ou não.

            static bool ehPrimo(int numero)
            {
                if (numero <= 1)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (ehPrimo(numero))
            {
                Console.WriteLine(numero + " é um número primo.");
            }
            else
            {
                Console.WriteLine(numero + " não é um número primo.");
            }
        }
    }
}
