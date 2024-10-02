using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula7_EntradaDeDados
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
               mensagem explicativa.*/
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;
            Console.WriteLine($"A soma de {numero1} e {numero2} é igual a {soma}.");



        }
    }
}
