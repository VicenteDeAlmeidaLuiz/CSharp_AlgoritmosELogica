using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula10_EstrututraCondicionalIf_Else
{
    internal class IfElseContinuacao
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com um número inteiro");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Par!");

            }

            else
            {
                Console.WriteLine("Ímpar");

            }
            /*Exemplo de estrutura condicional composta*/


        }
    }
}
