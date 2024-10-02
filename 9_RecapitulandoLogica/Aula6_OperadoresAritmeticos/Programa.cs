using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula6_OperadoresAritmeticos
{
    internal class Programa
    {
        static void Main(string[] args)
        {

            int n1 = 3 + 4 * 2; /*Conforme a precedência a multiplicaçãos erá feita primeiro resultando 11*/
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2; /*O que está entre parentêses quebra a precedência e é executado primeiro resultando aqui em 14*/
            Console.WriteLine(n2);

            int n3 = 17 % 2; /*Aqui é o operador mod,resto da divisão,aqui o resultado será 1*/
            Console.WriteLine(n3);




        }
    }
}
