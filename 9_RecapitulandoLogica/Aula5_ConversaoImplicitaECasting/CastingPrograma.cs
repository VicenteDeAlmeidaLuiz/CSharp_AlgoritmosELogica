using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula5_ConversaoImplicitaECasting
{
    internal class CastingPrograma
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x; /*Isso aqui é possível pq float tem 4 bytes e double tem 8 então 4 bytes cabem em 8 bytes*/
            Console.WriteLine(y);

            /*Se eu fizer o processo inverso ai não vai dar pq os 8 bytes double não cabem no 4 bytes do float,sendo assim eu preciso usar o casting*/

            double d = 4.6;
            float f = (float)d;
            Console.WriteLine(f);

            /*Mesmo processo agora com double e int,levando em consideração que double tem ponto flutuante e int não*/

            double var1 = 52.69;
            int var2 = (int)var1;
            Console.WriteLine(var2); /*Aqui eu vou ter a perda de informação,o resultado será apenas o 52*/



        }
    }
}
