using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula10_EstrututraCondicionalIf_Else.Exercicios;

internal class NumeroNegativo
{
    /*Fazer um programa para ler um número inteiro e depois dizer se este número é negativo ou não*/

    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número:");
        double numero = double.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Este número é negativo");

        }
        else
        {

            Console.WriteLine("Este número é positivo");

        }


    }
}
