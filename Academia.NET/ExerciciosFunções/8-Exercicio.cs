using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções
{
    internal class _8_Exercicio
    {
        public static void funcoes()
        {
            //8) Ler um número inteiro e passar por parâmetro para uma função e 0, se o número é par, ou 1, se o número é ímpar.

            static int VerificarParImpar(int numero)
            {
                if (numero % 2 == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            static void lerImparPar()
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                int resultado = VerificarParImpar(numero);

                if (resultado == 0)
                {
                    Console.WriteLine(numero + " é um número par.");
                }
                else
                {
                    Console.WriteLine(numero + " é um número ímpar.");
                }
            }
        }
    }
}
