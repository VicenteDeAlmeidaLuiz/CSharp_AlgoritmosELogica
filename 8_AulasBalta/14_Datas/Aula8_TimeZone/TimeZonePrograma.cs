using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._14_Datas.Aula8_TimeZone
{
    internal class TimeZonePrograma
    {

        static void Main(string[] args)
        {
            var dateTime = DateTime.UtcNow;
            Console.WriteLine(dateTime.ToString());

            /*Em resumo, UtcNow é importante quando você precisa de um valor de data e hora que seja universal e não seja afetado pelo fuso horário local.*/



        }
    }
}
