using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula13_EstruturaRepetitivaWhile
{
    internal class WhilePrograma
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número!");
            double numero = double.Parse(Console.ReadLine());

            while (numero > 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite um número!");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Número negativo.");

                }


            }






        }
    }
}
