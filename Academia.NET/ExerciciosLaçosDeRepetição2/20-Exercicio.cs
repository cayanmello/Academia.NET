using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _20_Exercicio
    {
        public static void loop2()
        {
            //20.Foi realizada uma pesquisa de algumas características físicas da população de uma
            //certa região, a qual coletou os seguintes dados referentes a cada habitante para
            //serem analisados:
            //-sexo(masculino e feminino)
            //- cor dos olhos(azuis, verdes ou castanhos)
            //-cor dos cabelos(louros, castanhos, pretos)
            //-idade

            //Faça um algoritmo que determine e escreva:

            //-a maior idade dos habitantes
            //-a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            //e que tenham olhos verdes e cabelos louros.
            //O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

            int maiorIdade = int.MinValue;
            int contMulheresVerdesLouros = 0;

            Console.WriteLine("Informe os dados dos habitantes. Para encerrar, digite -1 como idade.");

            while (true)
            {
                Console.Write("Sexo (M/F): ");
                char sexo = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (sexo == 'M' || sexo == 'F')
                {
                    Console.Write("Cor dos olhos (A para azuis, V para verdes, C para castanhos): ");
                    char corOlhos = Char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    Console.Write("Cor dos cabelos (L para louros, C para castanhos, P para pretos): ");
                    char corCabelos = Char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    Console.Write("Idade: ");
                    int idade;
                    if (!int.TryParse(Console.ReadLine(), out idade) || idade == -1)
                    {
                        break;
                    }

                    if (idade > maiorIdade)
                    {
                        maiorIdade = idade;
                    }

                    if (sexo == 'F' && idade >= 18 && idade <= 35 && corOlhos == 'V' && corCabelos == 'L')
                    {
                        contMulheresVerdesLouros++;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida para sexo. Por favor, digite M ou F.");
                }
            }

            Console.WriteLine($"Maior idade dos habitantes: {maiorIdade}");
            Console.WriteLine($"Quantidade de mulheres com idade entre 18 e 35 anos, olhos verdes e cabelos louros: {contMulheresVerdesLouros}");
        }
    }
}
