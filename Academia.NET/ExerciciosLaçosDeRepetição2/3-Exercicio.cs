using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _3_Exercicio
    {
        public static void loop2()
        {
            //3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
            //Se o usuário digitar 0 o programa em VS deve parar. 
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

            int numero;

            while (true)
            {
                Console.Write("Digite um número (ou 0 para sair): ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero} é um número par.");
                }
                else
                {
                    Console.WriteLine($"{numero} é um número ímpar.");
                }

                bool primo = VerificarPrimo(numero);
                if (primo)
                {
                    Console.WriteLine($"{numero} é um número primo.");
                }
                else
                {
                    Console.WriteLine($"{numero} não é um número primo.");
                }
            }
        }

        static bool VerificarPrimo(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int index = 2; index <= Math.Sqrt(num); index++)
            {
                if (num % index == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
