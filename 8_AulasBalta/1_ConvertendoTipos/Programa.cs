using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._1_ConvertendoTipos
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.5f;

            real = inteiro; /*Aqui a conversão é possível então não precisamos fazer nada,chamamos isso de conversão implicita*/
            inteiro = (int)real; /*Aqui eu não posso converter,então preciso fazer o casting também chamado de conversão explícita */

            Console.WriteLine(inteiro);
            Console.WriteLine("_______________________________________________________________________________________");

            /*Podemos fazer a conversão também utilizando o toString,porém espera-se sempre uma string e ai utilizamos o ToString*/


            int inteiro1 = 200;
            float real1 = 30.5f;

            string valorReal = real1.ToString();
            Console.WriteLine(valorReal);
            Console.WriteLine(inteiro1);
            Console.WriteLine("_______________________________________________________________________________________");

            /*Podemos também usar o convert para fazer a conversão,o convert arredonda o valor.Exsitem outros métodos no convert também como
             ToBoolean,ToDouble etc*/

            int inteiro2 = 300;
            float real2 = 40.85f;

            inteiro2 = Convert.ToInt32(real2);
            Console.WriteLine(inteiro2);

            /*O parse também faz a conversão.porém obrigatoriamente precisa ser string*/

            Console.WriteLine("_______________________________________________________________________________________");

            int inteiro3 = 500;
            float real3 = 452.69f;
            real3 = int.Parse("400");
            Console.WriteLine(real3);

        }
    }
}
