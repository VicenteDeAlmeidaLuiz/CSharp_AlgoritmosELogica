//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgoritmosELogicaCsharp._2_EstruturaCondicional.Aula3_OperadoresDeAtribuicaoCumulativa
//{
//    internal class Exercicio2
//    {

//        static void Main(string[] args)
//        {
//            double idade, soma, media;
//            int cont;
//            soma = 0.0;
//            cont = 0;

//            idade = double.Parse(Console.ReadLine());

//            while (idade >= 0)
//            {
//                soma = soma + idade;
//                cont = cont + 1;
//                idade = double.Parse(Console.ReadLine());

//            }

//            if (cont == 0)
//            {
//                Console.WriteLine("Impossível Calcular");

//            }
//            else
//            {

//                media = soma / cont;
//                Console.WriteLine(media.ToString("F2"));

//            }

//            Console.ReadLine();






//        }
//    }
//}
