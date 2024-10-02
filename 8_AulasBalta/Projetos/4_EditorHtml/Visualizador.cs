using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.text.regularexpressions;
using system.threading.tasks;
using System;
using System.Text.RegularExpressions;

namespace algoritmoselogicacsharp.aulasbalta.projetos._4_editorhtml
{
    internal class visualizador
    {
        public static void show(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("modo de visualização");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            replace(texto);
            Console.WriteLine("----------------");
            Console.ReadKey();
            menu.show();



        }

        public static void replace(string texto)
        {

            var strong = new Regex("@\"<\\s*strong[^>]*>(.*?)<\\s*/\\s*strong>\"");
            var palavras = texto.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                if (strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(palavras[i].Substring(palavras[i].IndexOf('>') + 1,
                        (palavras[i].LastIndexOf('<') - 1) - palavras[i].IndexOf('>')));
                    Console.Write(" ");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");

                }
            }



        }
    }
}
