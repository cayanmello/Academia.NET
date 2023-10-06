using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _14_Exercicio
    {
        public static void loop2()
        {
            for (int index = 0; index <= 10; index++)
            {
                double resultado = Math.Pow(2, index);
                Console.WriteLine($"2^{index} = {resultado}");
            }
        }
    }
}
