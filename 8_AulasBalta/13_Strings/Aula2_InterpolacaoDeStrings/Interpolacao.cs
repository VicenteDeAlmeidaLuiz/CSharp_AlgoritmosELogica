using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._13_Strings.Aula2_InterpolacaoDeStrings
{
    internal class Interpolacao
    {
        static void Main(string[] args)
        {
            primeiraFormaDeInterpolacao();
            segundaFormaDeInterpolacao();
            terceiraFormaDeInterpolacao();



        }
        static void primeiraFormaDeInterpolacao()
        {
            var preco = 10.2;
            var texto = "O preço do produto é " + preco + ".Apenas na promoção.";
            Console.WriteLine(texto);
            Console.WriteLine("_____________________________________________________________________________");
        }
        static void segundaFormaDeInterpolacao()
        {
            var preco2 = 20.58;
            var preco3 = 50.00d;
            var texto2 = string.Format("O preço do produto é {0} apenas na promoção.O preço normal é {1}", preco2, preco3.ToString("F2"));
            Console.WriteLine(texto2);
            Console.WriteLine("_____________________________________________________________________________");

        }
        static void terceiraFormaDeInterpolacao()
        {
            var preco4 = 10.50;
            var preco5 = 20.50;
            var texto = $"o preço normal é de {preco5},mas na promoção está custando {preco4}";
            var texto2 = @$"Se eu quiser quebrar a linha pq o texto {preco5} está com um tamanho muito,mas muito {preco4} grande,
                           eu uso o arroba no ínicio.";
            Console.WriteLine(texto);
            Console.WriteLine(texto2);

        }
    }
}
