using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._9_MetodosEFuncoes
{
    internal class OutroExemplo
    {

        static void Main(string[] args)
        {
            MeuMetodo();
            RetornaNome("Vicente ", "Almeida");


        }

        static void MeuMetodo()
        {
            Console.WriteLine("CSharp é legal mesmo.");
        }

        static string RetornaNome(string nome, string sobrenome)
        {
            string nomeCompleto = nome + sobrenome;
            Console.WriteLine(nomeCompleto);
            return nomeCompleto;



        }
    }
}
