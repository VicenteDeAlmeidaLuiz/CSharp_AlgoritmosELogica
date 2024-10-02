using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._2_OperadoresAritmeticos
{
    internal class OperadoresAritmeticos
    {
        static void Main(string[] args)
        {
            /*Soma +
             Subtração -
            Multiplicação *
            Divisão / 

            Multiplicação e divisão são executados primeiro (ordem de precêdencia)
            Caso queira executar em outra ordem usar parênteses
            Aceita short,int,float,double e decimal*/

            int numero1 = 25;
            int numero2 = 30;
            int soma = numero1 + numero2;
            int subtracao = numero1 - numero2;
            int multiplicacao = numero1 * numero2;
            double divisao = numero1 / numero2;

            Console.WriteLine(soma);
            Console.WriteLine(subtracao);
            Console.WriteLine(multiplicacao);
            Console.WriteLine(divisao);

        }
    }
}
