using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._14_Datas.Aula2_ObtendoValoresDaData
{
    internal class ObtendoValoresData
    {

        static void Main()
        {
            var data = new DateTime(2020, 10, 12, 8, 23, 14); /*Craimos um datetime com ano,mês,dia,hora,minuto e segundo*/
            var outraData = new DateTime(2024, 09, 24, 20, 14, 50); /*Data PM,após o meio dia*/
            Console.WriteLine(data);
            Console.WriteLine(outraData);
            /*Pegando as informações da data de forma separada*/
            Console.WriteLine(outraData.Year);
            Console.WriteLine(outraData.Month);
            Console.WriteLine(outraData.Day);
            Console.WriteLine(outraData.Hour);
            Console.WriteLine(outraData.Minute);
            Console.WriteLine(outraData.Second);
            Console.WriteLine(outraData.DayOfWeek);
            Console.WriteLine(outraData.DayOfYear);

        }
    }
}
