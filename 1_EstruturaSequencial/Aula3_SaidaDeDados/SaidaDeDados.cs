//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgoritmosELogicaCsharp._1_EstruturaSequencial.Aula3_SaidaDeDados
//{
//    internal class SaidaDeDados
//    {
//        static void Main(string[] args)
//        {
//            /*Escrever qualquer texto na tela sem quebra de linha*/

//            Console.Write("Olá Mundo");
//            Console.Write("Bom dia");
//            Console.WriteLine();

//            /*Escrever qualquer texto na tela com quebra de linha*/
//            Console.WriteLine("Olá Mundo");
//            Console.WriteLine("Bom dia");

//            /*Imprimir valor de variável*/

//            double x = 10.35784;

//            Console.WriteLine(x);

//            /*Imprimindo o valor da variável com casas decimais*/
//            Console.WriteLine(x.ToString("F2"));
//            Console.WriteLine(x.ToString("F4"));

//            /*Imprimindo o valor da variável com separador ponto fazendo o import da biblioteca System.Globalization*/
//            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

//            /*Concatenando elementos*/

//            int a = 10;
//            int b = 20;

//            int resultado = a + b;
//            Console.WriteLine("RESULTADO = " + resultado);

//            double valorProduto = 10.50;
//            double valorRecebido = 11.00;
//            double troco = valorRecebido - valorProduto;
//            Console.WriteLine("O valor do troco é de " + troco + "reais.");
//            Console.WriteLine("O valor do troco é de " + troco + "reais.");
//            Console.WriteLine("O valor do troco é de " + troco.ToString("F2") + " reais.");



//        }
//    }
//}
