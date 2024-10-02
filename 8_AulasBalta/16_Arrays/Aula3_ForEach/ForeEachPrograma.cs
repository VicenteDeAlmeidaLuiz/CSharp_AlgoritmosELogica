using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._16_Arrays.Aula3_ForEach
{
    internal class ForeEachPrograma
    {
        static void Main(string[] args)
        {
            var meuArray = new int[5] { 10, 20, 30, 40, 50 };


            foreach (int item in meuArray)
            {
                Console.WriteLine(item);


            }

            var meuNome = new string[4] { "Vicente", "de", "Almeida", "Luiz" };
            foreach (string palavras in meuNome)
            {
                Console.WriteLine(palavras);

            }


        }
    }
}
