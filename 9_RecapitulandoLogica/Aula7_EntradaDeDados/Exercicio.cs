using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula7_EntradaDeDados
{
    internal class Exercicio
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o seu nome completo:");
            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            string sobrenome = vetor[1];

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numeroQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome,idade e altura (mesma linha):");
            string[] vetor1 = Console.ReadLine().Split(' ');
            string ultimoNome = vetor1[0];
            int idade = int.Parse(vetor1[1]);
            double altura = double.Parse(vetor1[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome + " " + sobrenome);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
