using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._15_Moedas.Aula1_TipoParaMoedas
{
    internal class TiposMoedas
    {
        static void Main(string[] args)
        {
            /*Para trabalhar com valores como moedas,preços,salários etc usamos o decimal (sempre com m no final)*/

            decimal valor = 10.23m;
            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("en-US")));
            /*Como minha máquina está em português o separador é a vírgula.Passando para a cultureinfo dos Eua o separador será o ponto*/
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));/*Passando o C ele já formata com a moeda do país*/
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));


        }
    }
}
