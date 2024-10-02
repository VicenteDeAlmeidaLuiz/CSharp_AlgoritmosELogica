//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgoritmosELogicaCsharp._2_EstruturaCondicional.Aula2_Exercicio
//{
//    internal class Exercicio1
//    {
//        static void Main(string[] args)
//        {
//            double A, B, C, delta,r1,r2;

//            String[] vetor = Console.ReadLine().Split(' ');

//            A = double.Parse(vetor[0], CultureInfo.InvariantCulture); /*CultureInfo para aceitar . no separador*/
//            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
//            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

//            delta = Math.Pow(B, 2.0) - 4 * A * C;

//            if (A == 0 || delta < 0)
//            {
//                Console.WriteLine("Impossível Calcular");
//            }
//            else {
//                r1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
//                r2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
//                Console.WriteLine("R1" + r1.ToString("F5", CultureInfo.InvariantCulture));
//                Console.WriteLine("R2" + r2.ToString("F5", CultureInfo.InvariantCulture));

//            }





//        }
//        }
//}
