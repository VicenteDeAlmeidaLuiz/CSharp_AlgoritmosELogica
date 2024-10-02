using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace algoritmoselogicacsharp.aulasbalta._13_strings.aula4_startswith_endswith
{
    internal class programa
    {
        static void main(string[] args)
        {
            var meunome = "vicente de almeida luiz";
            Console.WriteLine(meunome.StartsWith("vi")); /*startswith valida se o texto começa com,retorna sempre true ou false*/
            Console.WriteLine(meunome.StartsWith("vi"));/*aqui retorna false pois é casesensitive*/
            Console.WriteLine(meunome.StartsWith("vicente", StringComparison.OrdinalIgnoreCase));/*aqui ignorando o case sensitive*/
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine(meunome.EndsWith("luiz"));/*endswith valida se o texto termina com,retorna sempre true ou false*/
            Console.WriteLine(meunome.EndsWith("luiz"));/*aqui retorna false pois é casesensitive*/
            Console.WriteLine(meunome.EndsWith("luiz", StringComparison.OrdinalIgnoreCase));/*aqui ignorando o case sensitive*/
        }
    }
}
