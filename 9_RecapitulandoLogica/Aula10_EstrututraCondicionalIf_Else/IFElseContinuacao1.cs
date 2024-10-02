using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula10_EstrututraCondicionalIf_Else;

internal interface IFElseContinuacao1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual a hora atual?");
        int hora = int.Parse(Console.ReadLine());

        if (hora < 12)
        {
            Console.WriteLine("Bom dia!!");

        }
        else if (hora >= 12 && hora < 18)
        {
            Console.WriteLine("Boa tarde!!");
        }
        else
        {
            Console.WriteLine("Boa noite!");

        }


    }
}
