using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula13_EstruturaRepetitivaWhile;

internal class Exercicio1
{
    static void Main(string[] args)
    {
        /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
       incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
       impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/

        Console.WriteLine("Digite a senha númerica:");
        int senha = int.Parse(Console.ReadLine());

        while (senha != 2002)
        {
            Console.WriteLine("Senha Inválida");
            Console.WriteLine("Digite a senha númerica:");
            senha = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("Acesso permitido!!");




    }
}
