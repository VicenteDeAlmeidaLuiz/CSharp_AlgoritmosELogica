using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._14_Datas.Aula10_TreMetodosUteis
{
    internal class ProgramaMetodosUteis
    {
        static void Main(string[] args)
        {
            /*Quantos dias tem o Mês*/
            Console.WriteLine(DateTime.DaysInMonth(2024, 10)); /*Ano 2024 mês 9*/
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); /*Aqui retorna um bool informando se estamos ou não no horário de verão*/
        }

        static bool IsWeekend(DayOfWeek hoje)
        {
            return hoje == DayOfWeek.Saturday || hoje == DayOfWeek.Sunday;

            /*Função pronta para saber se o dia é fim de semana ou não*/


        }
    }
}
