using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula7_EntradaDeDados
{
    internal class EntradaDadosPrograma
    {
        static void Main(string[] args)
        {
            /*Console readline le a entrada até a quebra de linha e retorna os dados lidos na formma de string*/
            string frase = Console.ReadLine();


            string cor1 = Console.ReadLine();
            string cor2 = Console.ReadLine();
            string cor3 = Console.ReadLine();
            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(cor1);
            Console.WriteLine(cor2);
            Console.WriteLine(cor3);
            Console.WriteLine("_______________________________________");

            /*Agora usando vetor para utilização de mais de uma string na mesma linha*/


            string[] vetorPalavras = Console.ReadLine().Split(' ');
            string palavra1 = vetorPalavras[0];
            string palavra2 = vetorPalavras[1];
            string palavra3 = vetorPalavras[2];
            Console.WriteLine("Você digitou tudo junto: ");
            Console.WriteLine(palavra1);
            Console.WriteLine(palavra2);
            Console.WriteLine(palavra3);




        }
    }
}
