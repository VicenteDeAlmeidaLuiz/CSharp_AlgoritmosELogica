using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._13_Strings.Aula7_Metodos_Adicionais
{
    internal class MetodosAddPrograma
    {
        static void Main(string[] args)
        {
            string textinho = "Um Texto Qualquer Para Fins DidátiCOS";
            Console.WriteLine(textinho.ToLower()); /*Converte todo o texto para mínúsculo*/
            Console.WriteLine(textinho.ToUpper()); /*Converte todo o texto para maíusculo*/
            Console.WriteLine(textinho.Insert(5, "AQUI")); /*Insere o texto no índice*/
            Console.WriteLine(textinho.Remove(5, 5)); /*A partir do índice 5 eu removo os próximos cinco caracteres*/
            Console.WriteLine(textinho.Length); /*Conta quantos caracteres tem na string*/
        }
    }
}
