using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._14_Datas.Aula7_CultureInfo
{
    internal class CultureInfoPrograma
    {
        static void Main(string[] args)
        {
            /*Minha máquina está em português mas se eu quisesse transformar a data/hora para outro país eu uso o culture info*/
            var pt = new CultureInfo("pt-BR"); /*Portugues de portugal*/
            var br = new CultureInfo("pt-BR"); /*Português do Brasil*/
            var en = new CultureInfo("en-UK"); /*IngLês britânico*/
            var enu = new CultureInfo("en-US"); /*IngLês dos Eua*/
            var din = new CultureInfo("de-DE"); /*Dinamarques*/
            var atual = CultureInfo.CurrentCulture; /*Pega o formato de data e hora configurado na máquina*/
            Console.WriteLine(DateTime.Now.ToString(en));
            Console.WriteLine(DateTime.Now.ToString("D", en)); /*Passando o D ele mostra a data por extenso*/
            Console.WriteLine(DateTime.Now.ToString("D", din));
            Console.WriteLine(DateTime.Now.ToString("D", atual));




        }
    }
}
