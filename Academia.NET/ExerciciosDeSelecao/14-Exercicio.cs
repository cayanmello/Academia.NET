using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _14_Exercicio
    {
        public static void selecao()
        {
            //14 - Faça um programa que peça o tamanho de um arquivo para download(em MB) e a velocidade de um
            //link de Internet(em Mbps). Em seguida, calcule e informe o tempo aproximado de download
            //do arquivo usando este link(em minutos).

            Console.Write("Digite o tamanho do arquivo para download (em MB): ");
            double tamanhoArquivoMB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade do link de Internet (em Mbps): ");
            double velocidadeMbps = Convert.ToDouble(Console.ReadLine());

            double tamanhoArquivoBits = tamanhoArquivoMB * 8 * 1_000_000;

            double tempoSegundos = tamanhoArquivoBits / (velocidadeMbps * 1_000_000);

            double tempoMinutos = tempoSegundos / 60;

            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos.");
        }
    }
}
