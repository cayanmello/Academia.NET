using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _04_Exercicio
    {
        public static void loop2()
        {
            //4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            //de votos em branco. 

            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;

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
                }
                else if (voto == "ZECA")
                {
                    votosZeca++;
                }
                else if (voto == "BRANCO")
                {
                    votosBranco++;
                }
                else
                {
                    Console.WriteLine("Voto inválido. Por favor, digite JOAO, ZECA, BRANCO ou FIM.");
                }
            }

            Console.WriteLine($"Total de votos para JOAO: {votosJoao}");
            Console.WriteLine($"Total de votos para ZECA: {votosZeca}");
            Console.WriteLine($"Total de votos em branco: {votosBranco}");
        }
    }
}
