using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._13_Strings.Aula5_Equals
{
    internal class ProgramaEquals
    {

        static void Main(string[] args)
        {

            string texto = "Essa é a minha string de teste";
            Console.WriteLine(texto.Equals("Este"));/*Equals serve para comparar se a string é igual,para retornar true a string tem que ser 
                                                    * exatamente igual*/
            Console.WriteLine(texto.Equals("Essa é a minha string de teste"));
            Console.WriteLine(texto.Equals("essa é a minha string de teste", StringComparison.OrdinalIgnoreCase)); /*Ignorando o case sensitive*/


        }
    }
}
