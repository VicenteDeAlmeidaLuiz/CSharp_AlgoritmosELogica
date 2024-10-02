using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._14_Datas.Aula4_PadroesDeFormatacao
{
    internal class PadroesFormatacao
    {
        static void Main()
        {

            var data = DateTime.Now;
            var formatada = String.Format("{0:t}", data); /*Usando t retorna a hora compactada*/
            var formatadad = String.Format("{0:d}", data); /*Usando d retorna a data atual compactada*/
            var formatadaT = String.Format("{0:T}", data); /*Usando T retorna a hora atual completa*/
            var formatadaD = String.Format("{0:D}", data); /*Usando D retorna a data inteira por extenso*/
            var formatadaf = String.Format("{0:f}", data); /*Usando f retorna a data e a hora por extenso*/
            var formatadag = String.Format("{0:g}", data); /*Usando g retorna a data e a hora resumidas*/
            var formatadar = String.Format("{0:r}", data); /*Usando r retorna a data e a hora em um padrão GMT*/
            var formatadas = String.Format("{0:s}", data); /*Usando s retorna a data e a hora em um padrão que eu não sei qual*/
            var formatadau = String.Format("{0:u}", data); /*Usando u retorna a data e a hora em um padrão universal*/
            Console.WriteLine(formatada);
            Console.WriteLine(formatadad);
            Console.WriteLine(formatadaT);
            Console.WriteLine(formatadaD);
            Console.WriteLine(formatadaf);
            Console.WriteLine(formatadag);
            Console.WriteLine(formatadar);
            Console.WriteLine(formatadas);
            Console.WriteLine(formatadau);




        }
    }
}
