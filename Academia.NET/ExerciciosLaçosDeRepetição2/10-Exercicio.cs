using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosLaçosDeRepetição2
{
    internal class _10_Exercicio
    {
        public static void loop2()
        {
            //10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
            //Número de pessoas do sexo masculino.
            //Número de pessoas do sexo feminino.
            //Número de pessoas com idade inferior a 30 anos.
            //Número de pessoas com idade superior a 60 anos.
            //Média de idade das mulheres.

            int pessoasMasculinas = 0;
            int pessoasFemininas = 0;
            int pessoasMenos30Anos = 0;
            int pessoasMais60Anos = 0;
            int somaIdadesMulheres = 0;
            int totalMulheres = 0;

            for (int index = 0; index < 50; index++)
            {
                Console.WriteLine($"Informe o nome da pessoa {index + 1}:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Informe o sexo da pessoa {index + 1} (M/F):");
                char sexo = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                Console.WriteLine($"Informe a idade da pessoa {index + 1}:");
                int idade = int.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    pessoasMasculinas++;
                }
                else if (sexo == 'F')
                {
                    pessoasFemininas++;
                    somaIdadesMulheres += idade;
                    totalMulheres++;
                }

                if (idade < 30)
                {
                    pessoasMenos30Anos++;
                }
                else if (idade > 60)
                {
                    pessoasMais60Anos++;
                }
            }

            Console.WriteLine($"Número de pessoas do sexo masculino: {pessoasMasculinas}");
            Console.WriteLine($"Número de pessoas do sexo feminino: {pessoasFemininas}");
            Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {pessoasMenos30Anos}");
            Console.WriteLine($"Número de pessoas com idade superior a 60 anos: {pessoasMais60Anos}");

            double mediaIdadeMulheres = totalMulheres > 0 ? (double)somaIdadesMulheres / totalMulheres : 0;
            Console.WriteLine($"Média de idade das mulheres: {mediaIdadeMulheres:F2}");
        }
    }
}
