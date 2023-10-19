﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.NET.ExerciciosSequenciais
{
    internal class _9_Exercicio
    {
        public static void sequenciais()
        {
            //9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior
            //ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
            //Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00;
            //se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
            //Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            //da entrada e das duas prestações, de acordo com as regras acima.
            //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
            //conseqüente pagamento dos boletos das duas prestações.

            Console.WriteLine("Digite o valor da mercadoria: ");
            double valorMercadoria = Convert.ToDouble(Console.ReadLine());

            double entrada = valorMercadoria / 3;
            entrada = Math.Ceiling(entrada);
            double prestacao = entrada;

            Console.WriteLine($"Valor da entrada: R${entrada}");
            Console.WriteLine($"Valor das duas prestações: R${prestacao}");

            Console.ReadKey();
        }
    }
}
