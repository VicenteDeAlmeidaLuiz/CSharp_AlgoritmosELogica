using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._17_Exceptions.Aula2_TryCatch
{
    internal class TratandoErrosPrograma
    {
        static void Main(string[] args)
        {

            var array = new int[3];

            try
            {
                for (var index = 0; index < 10; index++)
                {

                    Console.WriteLine(array[index]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista!!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); /*Recebe uma mensagem informando do que se trata o erro*/
                Console.WriteLine("Ops algo deu errado!!");

            }




        }
    }
}
