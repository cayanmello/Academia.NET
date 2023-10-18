using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosFunções
{
    internal class _2_Exercicio
    {
        static int[] vetor = new int[10];
        public static void funcoes()
        {
            //2) Fazer programa que tenha duas funções.
            //i) para ler um vetor de 10 elementos(variável global)
            //ii) para verificar e apresentar a quantidade de elementos pares que este vetor possui.

            LerVetor();
            ContarElementosPares();

            static void LerVetor()
            {
                Console.WriteLine("Digite 10 números: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Elemento {i + 1}; ");
                    vetor[i] = int.Parse(Console.ReadLine());
                }
            }

            static void ContarElementosPares()
            {
                int contadorPares = 0;
                foreach (int i in vetor)
                {
                    if (i % 2 == 0)
                    {
                        contadorPares++;
                    }
                }
                Console.WriteLine($"O vetor possuí {contadorPares} elemento(s) par(es).");
            }
        }
    }
}
