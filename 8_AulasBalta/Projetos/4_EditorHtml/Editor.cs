using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta.Projetos._4_EditorHtml
{
    internal class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("----------------");
            Inicio();

        }

        public static void Inicio()
        {
            var arquivo = new StringBuilder();

            do
            {
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------------");
            Console.WriteLine(" Deseja salvar o arquivo?");
            Visualizador.Show(arquivo.ToString());

        }
    }
}
