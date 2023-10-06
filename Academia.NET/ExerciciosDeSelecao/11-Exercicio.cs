using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosDeSelecao
{
    internal class _11_Exercicio
    {
        public static void selecao()
        {
            //11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis(uma para hora e outra para minutos).
            //O programa deve exibir se a hora digitada está ou não válida. 
            //Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

            Console.Write("Digite a hora (de 0 a 23): ");
            int hora = int.Parse(Console.ReadLine());

            Console.Write("Digite os minutos (de 0 a 59): ");
            int minutos = int.Parse(Console.ReadLine());

            if (hora >= 0 && hora <= 23 && minutos >= 0 && minutos <= 59)
            {
                Console.WriteLine("Hora válida!");
            }
            else
            {
                Console.WriteLine("Hora inválida!");
            }
        }
    }
}
