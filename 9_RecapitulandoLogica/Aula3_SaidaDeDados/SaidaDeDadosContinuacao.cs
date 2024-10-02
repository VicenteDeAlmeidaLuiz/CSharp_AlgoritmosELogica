using System;
using System.Globalization;


namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula3_SaidaDeDados
{
    internal class SaidaDeDadosContinuacao
    {
        static void Main(string[] args)
        {
            /*Saída de dados com variáveis*/

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine("Controlando as casas decimais do double,nesse caso duas casas decimais " + saldo.ToString("F2"));
            Console.WriteLine("Controlando as casas decimais do double,nesse caso quatro casas decimais " + saldo.ToString("F4"));
            Console.WriteLine("Imprimindo o double com o ponto como separador " + saldo.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Imprimindo o double com o ponto como separador e controlando as casas decimais " + saldo.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
