using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._14_Datas.Aula3_FormatandoDatas
{
    internal class FormatDatas
    {
        static void Main(string[] args)
        {
            var data = DateTime.Now;
            var formatada = String.Format("{0:yyyy}", data); /*Para exibir o ano*/
            var formatadaMes = String.Format("{0:M}", data); /*Para exibir o mes*/
            var formatadaAnoMesDia = String.Format("{0:yyyy-MM-dd}", data); /*Para exibir ano,mês e dia (se passar m minusculo ele tras o minuto)*/
            var formatadaComBarra = String.Format("{0:yyyy/MM/dd}", data); /*Para exibir ano,mês e dia formatado com barra,pode ser com outro separador também*/
            var formatadaEmPrt = String.Format("{0:dd/MM/yyyy}", data); /*Para exibir no formato do Brasil*/
            var formatadaEmPrtCompondoHrs = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data); /*Para exibir no formato do Brasil compondo a hora*/
            Console.WriteLine(formatada);
            Console.WriteLine(formatadaMes);
            Console.WriteLine(formatadaAnoMesDia);
            Console.WriteLine(formatadaComBarra);
            Console.WriteLine(formatadaEmPrt);
            Console.WriteLine(formatadaEmPrtCompondoHrs);


        }
    }
}
