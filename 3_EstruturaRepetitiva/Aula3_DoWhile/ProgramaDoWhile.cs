//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgoritmosELogicaCsharp._3_EstruturaRepetitiva.Aula3_DoWhile
//{
//    internal class ProgramaDoWhile
//    {
//        static void Main(string[] args)
//        {
//            char repetir;

//            do
//            {
//                Console.WriteLine("Digite a temperatura em Celsius:");
//                double tempCelsius = double.Parse(Console.ReadLine());
//                double conversao = (tempCelsius * 1.8) + 32.0;
//                Console.WriteLine("Equivalente em Farenheit: " + conversao.ToString("F1"));
//                Console.WriteLine("Deseja repetir? (s/n)");
//                repetir = char.Parse(Console.ReadLine());

//            }
//            while (repetir == 's');


//        }
//    }
//}

///*Estrutura repetitiva menos utilizada,mas em alguns casos se encaixa melhor ao problema.
// O bloco de comandos executa pelo menos uma vez,pois a condição é verificada no final*/
