using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._13_Strings.Aula8_ManipulandoStrings
{
    internal class ManipulacaoStrings
    {
        static void Main(string[] args)
        {
            var texto = "Isso é uma frase,não um texto.";
            Console.WriteLine(texto.Replace("Isso", "Essa")); /*Substituição na string*/
            Console.WriteLine(texto.Replace("a", "X")); /*Substitui todos os as minúsculos por X maíusculo*/

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);
            Console.WriteLine(divisao[5]);

            var resultado = texto.Substring(10, 16);
            Console.WriteLine(resultado);

            var texto1 = "                    Isso é uma frase,não um texto,com trim";

            Console.WriteLine(texto.Trim()); /*Trim limpa os espaços do meio e do fim*/


        }
    }
}
