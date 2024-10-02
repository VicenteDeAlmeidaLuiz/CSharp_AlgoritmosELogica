using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._14_Datas.Aula9_TimeSpan
{
    internal class TimeSpanPrograma
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timsSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timsSpanNanoSegundos);


            var timsSpanHoraMinutoSegundos = new TimeSpan(5, 12, 8);
            Console.WriteLine(timsSpanHoraMinutoSegundos);

        }
    }
}
