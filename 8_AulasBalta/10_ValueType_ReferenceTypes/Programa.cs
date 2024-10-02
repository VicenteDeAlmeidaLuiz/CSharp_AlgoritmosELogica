using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._10_ValueType_ReferenceTypes
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            int x = 25;
            int y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("_____________________________________________");

            x = 32;
            Console.WriteLine(x); /*Aqui é uma cópia de x,um valor atribuido*/
            Console.WriteLine(y);
            Console.WriteLine("_____________________________________________");

            var array = new string[2];
            array[0] = "Item 1";
            var array1 = array;
            Console.WriteLine(array[0]);
            Console.WriteLine(array1[0]);
            Console.WriteLine("_____________________________________________");

            array[0] = "Item 2";
            Console.WriteLine(array[0]);
            Console.WriteLine(array1[0]);





        }
    }
}
