using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._16_Arrays.Aula2_PercorrendoUmArray
{
    internal class PercorrendoArrayPrograma
    {
        static void Main(string[] args)
        {
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }



        }
    }
}
