using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._14_Datas.Aula6_ComparandoDatas
{
    internal class CompaDatas
    {
        static void Main(string[] args)
        {

            var data = DateTime.Now;

            if (data == DateTime.Now)
            {
                Console.WriteLine("São iguais"); /*Aqui nunca vai dar pq na execução ele pega até a fração do segundo,então nunca vai ser igual
                                                  Para resolver isso precisamos pegar o date,que ai compara só as horas*/

            }

            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("São iguais!!"); /*Aqui podemos usar o maior igual,menor igual etc,também*/

            }



        }
    }
}
