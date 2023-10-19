using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Academia.NET.ExerciciosFunções
{
    internal class desafio
    {
        public static void funcoes()
        {
            //Ler um vetor de inteiros com 10 elementos e passar por parâmetro para uma função que verifica e retorna o menor elemento do vetor.


            static int EncontrarMenorElemento(int[] vetor)
            {
                int menor = vetor[0];

            for (int i = 1; i < vetor.Length; ++i)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }

            return menor;
        }
            menorElemento();

            static void menorElemento()
            {
                int[] vetor = new int[10];

                Console.WriteLine("Digite 10 numeros inteiros para preencher o vetor:");
                for (int i = 0; i < 10; ++i)
                {
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                int menorElemento = EncontrarMenorElemento(vetor);

                Console.WriteLine("O menor elemento no vetor é: " + menorElemento);
            }
        }
    }
}
