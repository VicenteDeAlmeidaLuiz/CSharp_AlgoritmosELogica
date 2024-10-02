using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._13_Strings.Aula3_ComparacaoDeStrings
{
    internal class ProgramaComparadorStrings
    {
        static void Main(string[] args)
        {
            /*CompareTo serve para compararmos strings,mas retorna sempre 0 e 1 */
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando")); /*String igual retorna 0*/
            Console.WriteLine(texto.CompareTo("testando")); /*String diferente retorna 1*/
            Console.WriteLine("___________________________________________________________________");

            /*Contains retorna se a string contém algum trecho do texto*/
            var texto1 = "Esse texto é um teste";
            Console.WriteLine(texto1.Contains("teste")); /*Se tiver retorna true*/
            Console.WriteLine(texto1.Contains("testando")); /*Se não tiver retorna false*/
            Console.WriteLine(texto1.Contains("TEXTO", StringComparison.OrdinalIgnoreCase)); /*Aqui ele ignora o case sensitive*/




        }
    }
}
