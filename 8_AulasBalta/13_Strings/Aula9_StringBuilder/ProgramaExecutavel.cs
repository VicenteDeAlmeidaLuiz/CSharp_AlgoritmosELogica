using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._13_Strings.Aula9_StringBuilder
{
    internal class ProgramaExecutavel
    {
        static void Main(string[] args)
        {
            var outroTexto = new StringBuilder();
            outroTexto.Append("Essa frase é um teste"); /*Vai compondo as strings*/
            outroTexto.Append("é um teste");
            outroTexto.Append("Essa frase");
            outroTexto.Append("Essa frase é");

            Console.WriteLine(outroTexto);



        }
    }
}
