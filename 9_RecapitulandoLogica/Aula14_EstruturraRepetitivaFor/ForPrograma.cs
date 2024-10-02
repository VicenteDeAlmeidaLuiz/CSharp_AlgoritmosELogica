using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula14_EstruturraRepetitivaFor;

internal class ForPrograma
{
    static void Main(string[] args)
    {
        Console.Write("Quantos números inteiros vc vai digitar?");
        int resposta = int.Parse(Console.ReadLine());
        int soma = 0;

        for (int i = 1; i <= resposta; i++)
        {
            Console.Write("Valor#" + i + " ");

            int valor = int.Parse(Console.ReadLine());
            soma += valor;
        }
        Console.WriteLine("Soma = " + soma);


    }
}
