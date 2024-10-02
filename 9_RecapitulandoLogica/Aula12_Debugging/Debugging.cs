using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula12_Debugging
{
    internal class Debugging
    {

        static void Main(string[] args)
        {
            /*Digitar 3 números e mostrar qual o maior dos 3*/
            /*F9 - marcar/desmarcar breakpoint
            • F5 - iniciar/continuar o debug
            • F10 - executar um passo (pula função)
            • F11 - executar um passo (entra na função)
            • SHIFT+F11 - sair do método em execução
            • SHIFT+F5 - parar debug
            */

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
