using System;
using System.Globalization;


namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula7_EntradaDeDados
{
    internal class EntradaDeDadosContinuacao
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine()); /*Tenho que fazer o Parse pq o readline só aceita string*/
            char caracter = char.Parse(Console.ReadLine()); /*Mesma situação acima*/
            double numeroDouble = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); /*Para poder digitar com ponto*/

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(numero);
            Console.WriteLine(caracter);
            Console.WriteLine(numeroDouble.ToString("F2", CultureInfo.InvariantCulture)); /*Para mostrar com separador ponto*/
            Console.WriteLine("______________________________________________________");

            /*Com dados na mesma linha*/

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]); /*Como o vetor é de strings eu tenho que fazer o Parse*/
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
