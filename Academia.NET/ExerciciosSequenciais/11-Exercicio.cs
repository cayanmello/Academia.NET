using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosSequenciais
{
    internal class _11_Exercicio
    {
        public static void sequenciais()
        {
            //11) Escreva um algoritmo para ler o número de eleitores de um município,
            //o número de votos brancos, nulos e válidos. 
            //Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

            int totalEleitores, votosBrancos, votosNulos, votosValidos;

            Console.Write("Digite o número de eleitores: ");
            totalEleitores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de votos brancos: ");
            votosBrancos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de votos nulos: ");
            votosNulos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de votos válidos: ");
            votosValidos = Convert.ToInt32(Console.ReadLine());

            double percentualBrancos = (votosBrancos * 100.0) / totalEleitores;
            double percentualNulos = (votosNulos * 100.0) / totalEleitores;
            double percentualValidos = (votosValidos * 100.0) / totalEleitores;

            Console.WriteLine($"Percentual de votos brancos: {percentualBrancos}%");
            Console.WriteLine($"Percentual de votos nulos: {percentualNulos}%");
            Console.WriteLine($"Percentual de votos válidos: {percentualValidos}%");
        }
    }
}
