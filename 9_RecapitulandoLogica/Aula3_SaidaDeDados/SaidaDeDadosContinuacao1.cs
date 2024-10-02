using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula3_SaidaDeDados
{
    internal class SaidaDeDadosContinuacao1
    {
        static void Main(string[] args)
        {
            int idade = 40;
            double saldo = 10.37589;
            string nome = "João";

            /*Usando placeholder para imprimir a variável:*/
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais.", nome, idade, saldo);
            /*Controlando o número de casa decimais do double*/
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            /*Usando interpolação para imrpimir as variáveis*/
            Console.WriteLine($"{nome} tem {idade} anos e o saldo bancário de {saldo:F2} reais.");


        }
    }
}
