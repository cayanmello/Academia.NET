using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _10_Exercicio
    {
        public static void selecao()
        {
            //10 - Faça um programa no VS que receba dados de dois atletas(nome, idade e altura).
            //O programa deve mostrar os dados do atleta mais novo e mais alto.

            Console.WriteLine("Digite os dados do primeiro atleta:");
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();

            Console.Write("Idade: ");
            int idade1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura (em metros): ");
            double altura1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite os dados do segundo atleta:");
            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();

            Console.Write("Idade: ");
            int idade2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura (em metros): ");
            double altura2 = Convert.ToDouble(Console.ReadLine());

            if (idade1 < idade2)
            {
                Console.WriteLine($"Atleta mais novo: {nome1}, {idade1} anos, {altura1}m de altura.");
            }
            else
            {
                Console.WriteLine($"Atleta mais novo: {nome2}, {idade2} anos, {altura2}m de altura.");
            }

            if (altura1 > altura2)
            {
                Console.WriteLine($"Atleta mais alto: {nome1}, {idade1} anos, {altura1}m de altura.");
            }
            else
            {
                Console.WriteLine($"Atleta mais alto: {nome2}, {idade2} anos, {altura2}m de altura.");
            }
        }
    }
}
