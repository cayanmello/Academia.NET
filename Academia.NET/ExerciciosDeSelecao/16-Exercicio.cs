using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _16_Exercicio
    {
        public static void selecao()
        {
            //16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.
            //Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            //na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase
            //Caso contrário, mostre uma mensagem indicando que os dois times irão se enfrentar novamente em um novo jogo.
            //ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            //ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            //plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

            Console.WriteLine("Digite o placar do jogo da primeira fase (time da casa x time de fora):");
            Console.Write("Time da casa: ");
            int placarTimeCasa = int.Parse(Console.ReadLine());

            Console.Write("Time de fora: ");
            int placarTimeFora = int.Parse(Console.ReadLine());

            if (placarTimeCasa > placarTimeFora)
            {
                int diferencaGols = placarTimeCasa - placarTimeFora;
                if (diferencaGols <= 2)
                {
                    Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");
                }
                else
                {
                    Console.WriteLine("O time de fora já se classificou para a próxima fase.");
                }
            }
            else if (placarTimeFora > placarTimeCasa)
            {
                int diferencaGols = placarTimeFora - placarTimeCasa;
                if (diferencaGols <= 2)
                {
                    Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");
                }
                else
                {
                    Console.WriteLine("O time de fora já se classificou para a próxima fase.");
                }
            }
            else
            {
                Console.WriteLine("O jogo terminou em empate. Um novo jogo será necessário para decidir.");
                Console.WriteLine("Digite o placar do segundo jogo (time da casa x time de fora):");
                Console.Write("Time da casa: ");
                int placarTimeCasaSegundoJogo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Time de fora: ");
                int placarTimeForaSegundoJogo = Convert.ToInt32(Console.ReadLine());

                if (placarTimeCasaSegundoJogo > placarTimeForaSegundoJogo)
                {
                    Console.WriteLine("O time da casa passou para a próxima fase!");
                }
                else if (placarTimeForaSegundoJogo > placarTimeCasaSegundoJogo)
                {
                    Console.WriteLine("O time de fora passou para a próxima fase!");
                }
                else
                {
                    Console.WriteLine("O segundo jogo também terminou em empate. Não há um vencedor claro.");
                }
            }
        }
    }
}
