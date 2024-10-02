using system;
using system.collections.generic;
using system.linq;
using system.text;
using System;
using System.Threading;

namespace algoritmoselogicacsharp.aulasbalta.projetos._2_cronometro
{
    internal class cronometro
    {
        static void main(string[] args)
        {
            menu();


        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("s = segundo: exemplo 10s = 10 segundos");
            Console.WriteLine("m = minuto: exemplo 10m = 10 minutos");
            Console.WriteLine("0 = sair");
            Console.WriteLine("quanto tempo deseja contar?");

            string dado = Console.ReadLine().ToLower();
            char tipo = char.Parse(dado.Substring(dado.Length - 1, 1));
            int tempo = int.Parse(dado.Substring(0, dado.Length - 1));
            int multiplicador = 1;

            if (tipo == 'm')
            {
                multiplicador = 60;
                if (tempo == 0)
                {
                    System.environment.exit(0);
                    start(tempo * multiplicador);

                }
            }

        }

        static void start(int tempo)
        {

            int tempoatual = 0;

            while (tempoatual != tempo)
            {
                Console.Clear();
                tempoatual++;
                Console.WriteLine(tempoatual);
                Thread.Sleep(1000);




            }
            Console.Clear();
            Console.WriteLine("cronômetro finalizado...");
            Thread.Sleep(2500);
            menu();

        }
    }
}
