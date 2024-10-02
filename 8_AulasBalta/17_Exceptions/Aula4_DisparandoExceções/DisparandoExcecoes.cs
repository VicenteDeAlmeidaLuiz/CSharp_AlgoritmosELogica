using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._17_Exceptions.Aula4_DisparandoExceções
{
    internal class DisparandoExcecoes
    {
        static void Main()
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
                //Console.WriteLine(ex.Message);
                //Console.WriteLine("Não encontrei o índice na lista!!");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message); /*Recebe uma mensagem informando do que se trata o erro*/
                Console.WriteLine("Falha ao cadastrar texto.");



            }

            Cadastrar("");
        }

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");


            }

        }
    }
}
