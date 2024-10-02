using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._7_Condicionais.Aula2_Switch
{
    internal class SwitchPrograma
    {
        static void Main(string[] args)
        {
            /*Utilizado quando temos muitas decisões
             Executado em cascata
            Devemos parar manualmente a execução com o comando break
            Possui uma execução padrão chamada default*/

            int valor = 1;

            switch (valor)
            {
                case 1: Console.WriteLine("Um"); break;
                case 2: Console.WriteLine("Dois"); break;
                case 3: Console.WriteLine("Três"); break;
                default: Console.WriteLine("4"); break;

            }

        }
    }
}
