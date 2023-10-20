using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _07_Exercicio
    {
        public static void selecao()
        {
            // 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            //O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            //exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

            Console.WriteLine("Envie o seu texto abaixo:");
            Console.Write(" ");
            string texto = Console.ReadLine();

            Console.WriteLine("Escreve a mensagem que deseja pesquisar: ");
            string palavraPesquisada = Console.ReadLine();

            if (texto.Contains(palavraPesquisada))
            {
                Console.WriteLine("O seu texto possuí a mensagem: " + palavraPesquisada + "!");
            }
            else
            {
                Console.WriteLine("O seu texto não possuí a palavra pesquisada!");
            }
        }
    }
}
