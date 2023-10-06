using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _19_Exercicio
    {
        public static void selecao()
        {
            //19 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            //plus: você pode gerar o número de forma randomica(função random c#).

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativasRestantes = 3;
            int tentativa;

            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

            while (tentativasRestantes > 0)
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = int.Parse(Console.ReadLine());

                if (tentativa == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou o número secreto: " + numeroSecreto);
                    break;
                }
                else if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior. Tentativas restantes: " + (--tentativasRestantes));
                }
                else
                {
                    Console.WriteLine("O número secreto é menor. Tentativas restantes: " + (--tentativasRestantes));
                }
            }

            if (tentativasRestantes == 0)
            {
                Console.WriteLine("Suas tentativas acabaram. O número secreto era: " + numeroSecreto);
            }

            Console.WriteLine("Obrigado por jogar! Pressione Enter para sair.");
            Console.ReadLine();
        }
    }
}
