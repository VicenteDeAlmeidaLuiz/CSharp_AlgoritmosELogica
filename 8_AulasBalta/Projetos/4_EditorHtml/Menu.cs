using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta.Projetos._4_EditorHtml
{
    internal class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green; /*Cor de fundo*/
            Console.ForegroundColor = ConsoleColor.Black; /*Cor da letra*/
            DesenhoTela();
            EscreveOpcoes();

            var opcao = short.Parse(Console.ReadLine());
            ManipularOpcoessMenu(opcao);

        }

        public static void DesenhoTela()
        {
            Console.Write("+");
            for (int i = 0; i < 30; i++)
            {

                Console.Write("-");

            }
            Console.WriteLine("+");
            Console.WriteLine("\n");


            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("|");
                Console.WriteLine("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            Console.WriteLine("\n");

        }

        public static void EscreveOpcoes()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo!");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");






        }

        public static void ManipularOpcoessMenu(short opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("Visualizar"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;

            }

        }
    }
}
