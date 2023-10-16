using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosMatrizes
{
    internal class _9_Exercicio
    {
        public static void matrizes()
        {
            //9) Leia uma matriz 3x3.Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.
            //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

            int[,] matriz = new int[3, 3];

            Console.WriteLine("Digite os valores da matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Digite um número para pesquisar se existe na matriz: ");
            int numero = int.Parse(Console.ReadLine());

            bool numeroExiste = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        numeroExiste = true;
                        break;
                    }
                }
                if (numeroExiste)
                {
                    break;
                }
            }

            if (numeroExiste)
            {
                Console.WriteLine("O número existe na matriz.");
            }
            else
            {
                Console.WriteLine("Número inexistente na matriz.");
            }
        }
    }
}
