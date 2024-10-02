using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._15_Moedas.Aula2_Math
{
    internal class MathPrograma
    {
        static void Main(string[] args)
        {
            decimal valor = 10536.25m;
            Console.WriteLine(Math.Round(valor)); /*Roud é usado para arredondar o valor*/
            Console.WriteLine(Math.Ceiling(valor)); /*Ceiling  é usado para arredondar o valor para cima*/
            Console.WriteLine(Math.Floor(valor)); /*Floor é usado para arredondar o valor para baixo*/

        }
    }
}
