using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções2
{
    internal class _07_Exercicio
    {
        public static void funcoes2()
        {
            //7 - Crie uma função chamada VerificarNumeroPrimo que recebe um vetor de números inteiros como parâmetro
            //e retorna verdadeiro se pelo menos um número primo estiver presente no vetor, e falso caso contrário.


            int[] numeros = { 4, 9, 5, 12, 7, 10 };

            bool temPrimo = VerificarNumeroPrimo(numeros);

            Console.WriteLine("Números no vetor:");
            ImprimirVetor(numeros);

            if (temPrimo)
            {
                Console.WriteLine("Pelo menos um número primo está presente no vetor.");
            }
            else
            {
                Console.WriteLine("Nenhum número primo está presente no vetor.");
            }
        }

        static bool VerificarNumeroPrimo(int[] numeros)
        {
            foreach (int numero in numeros)
            {
                if (ehPrimo(numero))
                {
                    return true;
                }
            }
            return false;
        }

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

        static void ImprimirVetor(int[] vetor)
        {
            foreach (int numero in vetor)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }
    }
}
