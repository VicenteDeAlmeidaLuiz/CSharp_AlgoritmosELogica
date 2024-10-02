using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._14_Datas.Aula4_PadroesDeFormatacao
{
    internal class AddValoresDatas
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(12));

            Console.WriteLine(data.AddMonths(1));

            Console.WriteLine(data.AddYears(1));

            Console.WriteLine(data.AddYears(-2));



        }
    }
}
