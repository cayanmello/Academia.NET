using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExercicioSequenciais
{
    internal class _10_Exercicio
    {
        public static void sequenciais()
        {
            //10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo
            //para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
            //realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as
            //notas de menor valor fossem distribuídas em número mínimo possível.
            //Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            //uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
            //Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas
            //de acordo com o critério da “distribuição ótima”.

            Console.WriteLine("Digite o valor do saque:");
            int valorSaque = int.Parse(Console.ReadLine());

            int[] notas = { 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine("Distribuição ótima das notas:");

            foreach (int nota in notas)
            {
                int quantidadeNotas = valorSaque / nota;
                if (quantidadeNotas > 0)
                {
                    Console.WriteLine($"{quantidadeNotas} nota(s) de R${nota},00");
                    valorSaque %= nota; // Atualiza o valor do saque após distribuir as notas de determinado valor
                }
            }

            Console.ReadKey();
        }
    }
}
