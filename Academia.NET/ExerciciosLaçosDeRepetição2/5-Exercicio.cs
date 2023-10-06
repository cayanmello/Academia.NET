using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _5_Exercicio
    {
        public static void loop2()
        {
            //5.Modifique o programa em VS anterior para aceitar votos nulos
            //(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
            //Ao final, informe o nome do candidato vencedor, o número de votos nulos
            //e o número de pessoas que votaram.

            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;
            int votosNulos = 0;
            int totalVotos = 0;

            string voto;

            Console.WriteLine("Digite o nome do candidato (JOAO, ZECA) ou BRANCO. Digite FIM para encerrar.");

            while (true)
            {
                Console.Write("Voto: ");
                voto = Console.ReadLine().ToUpper();

                if (voto == "FIM")
                {
                    break;
                }
                else if (voto == "JOAO")
                {
                    votosJoao++;
                    totalVotos++;
                }
                else if (voto == "ZECA")
                {
                    votosZeca++;
                    totalVotos++;
                }
                else if (voto == "BRANCO")
                {
                    votosBranco++;
                    totalVotos++;
                }
                else
                {
                    votosNulos++;
                    totalVotos++;
                }
            }

            Console.WriteLine($"Total de votos para JOAO: {votosJoao}");
            Console.WriteLine($"Total de votos para ZECA: {votosZeca}");
            Console.WriteLine($"Total de votos em branco: {votosBranco}");
            Console.WriteLine($"Total de votos nulos: {votosNulos}");
            Console.WriteLine($"Total de pessoas que votaram: {totalVotos}");

            string vencedor = (votosJoao > votosZeca) ? "JOAO" : "ZECA";
            Console.WriteLine($"Candidato vencedor: {vencedor}");
        }
    }
}
