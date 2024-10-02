using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula11_Funcoes
{
    internal class Funcoes
    {
        static void Main(string[] args)
        {
            /*Digitar 3 números e mostrar qual o amior dos 3*/

            Console.WriteLine("Digite 3 números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);


        }

        static double Maior(int a, int b, int c)
        {
            double maior;
            if (a > b && a > c)
            {
                maior = a;

            }
            else if (b > c)
            {
                maior = b;

            }
            else
            {
                maior = c;

            }
            return maior;


        }
    }
}
