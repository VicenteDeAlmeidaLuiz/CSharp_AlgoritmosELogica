//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgoritmosELogicaCsharp._3_EstruturaRepetitiva.Aula2_For
//{
//    internal class Exercicio1
//    {
//        static void Main(string[] args)

//        {
//            int min, max, soma;
//            Console.WriteLine("Digite o primeiro número:");
//            int numero1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Digite o segundo número:");
//            int numero2 = int.Parse(Console.ReadLine());

//            if (numero1 < numero2)
//            {
//                min = numero1;
//                max = numero2;

//            }
//            else
//            {
//                min = numero2;
//                max = numero1;
//            }
//            soma = 0;
//            for (int i = min + 1; i < max; i++)
//            {
//                if (i % 2 != 0)
//                {
//                    soma = soma + i;
//                }


//            }
//            Console.WriteLine(soma);


//        }
//    }
//}
