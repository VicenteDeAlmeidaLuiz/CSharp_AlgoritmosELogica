using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula1_TiposBasicosDeDados
{
    internal class ProgramaTiposBasicos
    {
        static void Main(string[] args)
        {
            SByte z = 100; /*Aqui é um tipo do .net */
            sbyte x = 100; /*Aqui é um tipo da linguagem C#  */

            byte n1 = 25; /*Byte é um exemplo que não aceita sinal,número negativo e vai do zero ao 255*/

            int n2 = 1000;
            int n3 = 2147483647; /*Valor máximo que aceita o int*/
            long n4 = 2147483648L; /*Maior que o int em armazenamento é o long,ao trabalhar com long é uma recomendação colocar o L no final da declaração*/

            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);


        }
    }
}
