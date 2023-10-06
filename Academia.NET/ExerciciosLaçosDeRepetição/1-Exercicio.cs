using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição
{
    internal class _1_Exercicio
    {
        public static void loop()
        {
            //1.Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n pessoas e calcular a média das idades.

            Console.Write("Digite a idade da pessoa 1: ");
            int pessoa1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da pessoa 2: ");
            int pessoa2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da pessoa 3: ");
            int pessoa3 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da pessoa 4: ");
            int pessoa4 = int.Parse(Console.ReadLine());

            int media = (pessoa1 + pessoa2 + pessoa3 + pessoa4) / 4;

            Console.WriteLine("A média de idade das pessoas é: " + media + " anos!");
        }
    }
}
