using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula1_TiposBasicosDeDados
{
    internal class ProgramaTiposBasicosContinuacao
    {
        static void Main(string[] args)
        {
            bool completo = false; /*Bool é o tipo que armazena verdadeiro ou falso (true ou false)*/
            Console.WriteLine(completo);
            char genero = 'M'; /*char é o tipo que armazena um único caracter,sempre entre aspas simples*/
            Console.WriteLine(genero);
            char letra = '\u0041'; /*char também aceita caracter unicode,nesse caso é o unicode da letra A*/
            Console.WriteLine(letra);
            float n5 = 4.5f; /*Float sempre com a letra f no final.Vai imprimir com vírgula pq é o padrão que está o meu computador*/
            Console.WriteLine(n5);
            double n6 = 4.5; /*double não precisa de nada ao final.Vai imprimir com vírgula pq é o padrão que está o meu computador*/
            Console.WriteLine(n6);
            string nome = "Maria"; /*string representa texto,cadeia de caracteres*/
            Console.WriteLine(nome);
            object obj1 = "Alex Brown"; /*Object é um tipo genérico,aceita qualquer coisa*/
            Console.WriteLine(obj1);
            object obj2 = 125;
            Console.WriteLine(obj2);
            object obj3 = true;
            Console.WriteLine(obj3);
            Console.WriteLine("__________________________________________________");
            int n1 = int.MinValue;
            Console.WriteLine("Menor valor aceito por int " + n1);
            int n2 = int.MaxValue;
            Console.WriteLine("Maior valor aceito por int " + n2); /*Posso usar essaas funções para todos os tipos,double,float etc*/
            double n3 = double.MinValue;
            Console.WriteLine("Menor valor aceito por double " + n3);
            double n4 = double.MaxValue;
            Console.WriteLine("Maior valor aceito por double " + n4);



        }
    }
}
