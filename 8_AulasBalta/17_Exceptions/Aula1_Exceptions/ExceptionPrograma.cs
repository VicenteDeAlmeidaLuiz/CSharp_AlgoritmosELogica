using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._17_Exceptions.Aula1_Exceptions
{
    internal class ExceptionPrograma
    {

        static void Main(string[] args)
        {
            var arr = new int[3];

            for (int index = 0; index < 10; index++)
            {
                /*Aqui vai dar erro pq o array tem 3 posições e o for vai iterar até a posição 10
                 * Erro apresentado: System.IndexOutOfRangeException (Aula introdutória)*/

                Console.WriteLine(arr[index]);

            }



        }
    }
}
