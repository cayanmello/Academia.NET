using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExercicioSequenciais
{
    internal class _5_Exercicio
    {
        public static void sequenciais()
        {
            //5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            //(medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            //consumido para percorrê-la(medido em l).

            Console.Write("Quantos km o carro percorreu? ");
            int kmPercorridos = int.Parse(Console.ReadLine());

            Console.Write("Quantos litros foi gasto no percurso? ");
            int volumeCombustivel = int.Parse(Console.ReadLine());

            int consumoMedio = kmPercorridos / volumeCombustivel;

            Console.WriteLine("A média de consumo do seu carro é: " + consumoMedio + " km/l");
        }
    }
}
