using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._4_OperadoresDeComparação
{
    internal class Comparacao
    {
        static void Main(string[] args)
        {
            /*Igual ==
             Diferente !=
            Maior que >
            Menor que <
            Maior ou igual a >=
            Menor ou igual a <=
            Podemos comparar qualquer tipo de dado,números,strings,bytes
            A comparação SEMPRE retorna verdadeiro ou falso TRUE ou FALSE*/

            int x = 25;
            Boolean comparacao = x == 0; /*False*/
            Boolean comparacao1 = x != 0; /*True*/
            Boolean comparacao2 = x > 0;    /*True*/
            Boolean comparacao3 = x < 0; /*False*/
            Boolean comparacao4 = x <= 0; /*False*/
            Boolean comparacao5 = x >= 0; /*True*/

            Console.WriteLine(comparacao);
            Console.WriteLine(comparacao1);
            Console.WriteLine(comparacao2);
            Console.WriteLine(comparacao3);
            Console.WriteLine(comparacao4);
            Console.WriteLine(comparacao5);



        }
    }
}
