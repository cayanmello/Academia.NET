using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _2_Exercicio
    {
        public static void loop2()
        {
            //2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.


            //Exemplo:
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.


            //Deseja informar outro número(s/ n)? S

            //Digite um número inteiro positivo: 12
            //Numero digitado: 20
            //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


            //Deseja informar outro número(s/ n)? N

            char continuar;

            do
            {
                Console.Write("Digite um número inteiro positivo: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"Número digitado: {numero}");
                Console.Write("Números inteiros pares entre 1 e {0}: ", numero);

                for (int index = 2; index < numero; index += 2)
                {
                    Console.Write(index + " ");
                }

                Console.WriteLine();

                Console.Write("Deseja informar outro número (s/n)? ");
                continuar = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (continuar == 's' || continuar == 'S');
        }
    }
}
