using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._9_MetodosEFuncoes
{
    internal class MetodosEFuncoes
    {
        static void Main(string[] args)
        {
            /*Invocação do método*/
            MeuMetodo("C# é legal", 87);

        }

        static void MeuMetodo(string parametro, int qualquerNumero)
        {   /*Criação do método*/
            Console.WriteLine(parametro);
            Console.WriteLine(qualquerNumero);
        }
    }

}
