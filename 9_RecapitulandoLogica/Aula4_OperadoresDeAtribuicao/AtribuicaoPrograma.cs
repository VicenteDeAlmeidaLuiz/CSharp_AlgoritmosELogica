using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula4_OperadoresDeAtribuicao
{
    internal class AtribuicaoPrograma
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            a += 2; /*O operador mais igual ele pega o valor que já tinha na variável (nesse caso 10) e soma mais dois*/
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);/*O operador vezes igual ele pega o valor que já tinha na variável (nesse caso 12) e multiplica por três*/

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s); /*Usando mais igual com string ele pega o que já tinha na string e faz algo como se fosse concatenação*/


        }
    }
}
