using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExercicioSequenciais
{
    internal class _12_Exercicio
    {
        public static void sequenciais()
        {
        //12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça.Sabendo - se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a
        //marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
        //dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.
        //Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia
        //Média do consumo = Total quilometragem / quantidade de combustível gasto
        //Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

            double marcacaoInicio, marcacaoFinal, litrosCombustivel, valorTotal, precoCombustivel = 6.90;

            Console.Write("Digite a marcação do odômetro no início do dia (em km): ");
            marcacaoInicio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a marcação do odômetro no final do dia (em km): ");
            marcacaoFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número de litros de combustível gasto: ");
            litrosCombustivel = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor total recebido dos passageiros: R$");
            valorTotal = Convert.ToDouble(Console.ReadLine());

            double totalQuilometragem = marcacaoFinal - marcacaoInicio;

            double mediaConsumo = totalQuilometragem / litrosCombustivel;

            double lucroDia = valorTotal - (litrosCombustivel * precoCombustivel);

            Console.WriteLine($"Média do consumo: {mediaConsumo:F2} Km/l");
            Console.WriteLine($"Lucro líquido do dia: R${lucroDia:F2}");
        }
    }
}
