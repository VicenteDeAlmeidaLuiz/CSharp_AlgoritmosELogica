using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._13_Strings.Aula6_Indices
{
    internal class IndicesPrograma
    {
        static void Main(string[] args)
        {
            var meuTexto = "A esperança é um urubu vestido de verde.";
            Console.WriteLine(meuTexto.IndexOf("é")); /*O indexof mostra a posição,o index que a string está na lista de caracteres*/
            Console.WriteLine(meuTexto.IndexOf("esperança"));
            Console.WriteLine(meuTexto.LastIndexOf("s")); /*LastIndex of ele trás o index da última posição na string*/

        }
    }
}
