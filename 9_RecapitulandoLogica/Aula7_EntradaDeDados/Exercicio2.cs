using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula7_EntradaDeDados
{
    internal class Exercicio2
    {
        /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
         hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
        decimais.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantas horas o funcionário trabalhou?");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor esse funcionário recebe por hora?");
            double valorHora = double.Parse(Console.ReadLine());

            double totalSalario = horas * valorHora;

            Console.WriteLine($"O salário do funcionário {nome} é de {totalSalario.ToString("F2")}.");



        }
    }
}
