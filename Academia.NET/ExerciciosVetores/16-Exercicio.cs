using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosVetores
{
    internal class _16_Exercicio
    {
        public static void vetores()
        {
            //16.Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
            //•A união de X com Y
            //•A diferença entre X e Y
            //•A interseção entre X e Y
            //Escreva o vetor resultado de cada uma das operações.

            int tamanho = 10;
            int[] X = new int[tamanho];
            int[] Y = new int[tamanho];

            Console.WriteLine("Digite 10 elementos para o vetor X:");
            LerVetor(X);

            Console.WriteLine("Digite 10 elementos para o vetor Y:");
            LerVetor(Y);

            int[] uniao = Uniao(X, Y);
            int[] diferenca = Diferenca(X, Y);
            int[] intersecao = Intersecao(X, Y);

            Console.WriteLine("\nVetor União:");
            MostrarVetor(uniao);

            Console.WriteLine("Vetor Diferença (X - Y):");
            MostrarVetor(diferenca);

            Console.WriteLine("Vetor Interseção:");
            MostrarVetor(intersecao);

            Console.ReadLine();
        }
        static void LerVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        static int[] Uniao(int[] X, int[] Y)
        {
            int[] uniao = new int[X.Length + Y.Length];
            Array.Copy(X, uniao, X.Length);
            Array.Copy(Y, 0, uniao, X.Length, Y.Length);
            return uniao;
        }
        static int[] Diferenca(int[] X, int[] Y)
        {
            int[] diferenca = new int[X.Length];
            for (int i = 0; i < X.Length; i++)
            {
                diferenca[i] = X[i];
                if (Array.IndexOf(Y, X[i]) != -1)
                {
                    diferenca[i] = 0;
                }
            }
            return diferenca;
        }

        static int[] Intersecao(int[] X, int[] Y)
        {
            int[] intersecao = new int[Math.Min(X.Length, Y.Length)];
            int contador = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (Array.IndexOf(Y, X[i]) != -1)
                {
                    intersecao[contador] = X[i];
                    contador++;
                }
            }
            Array.Resize(ref intersecao, contador);
            return intersecao;
        }
        static void MostrarVetor(int[] vetor)
        {
            foreach (var elemento in vetor)
            {
                Console.Write($"{elemento} ");
            }
            Console.WriteLine();
        }
    }
}
