using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula8_OperadoresComparativos
{
    internal class OpComparativosPrograma
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool condicao = a < 10; /*Menor que*/
            bool condicao1 = a < 20;
            bool condicao2 = a > 20; /*Maior que*/
            bool condicao3 = a > 5;
            Console.WriteLine(condicao);
            Console.WriteLine(condicao1);
            Console.WriteLine(condicao2);
            Console.WriteLine(condicao3);
            Console.WriteLine("__________________________________________");

            bool condicao4 = a <= 10; /*Menor igual*/
            bool condicao5 = a >= 10; /*Maior igual*/
            bool condicao6 = a == 10; /*Igual a*/
            bool condicao7 = a != 10; /*Diferente*/
            Console.WriteLine(condicao4);
            Console.WriteLine(condicao5);
            Console.WriteLine(condicao6);
            Console.WriteLine(condicao7);


        }
    }
}
