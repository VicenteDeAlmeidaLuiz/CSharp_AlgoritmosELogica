using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp._7_NovosExercicios.Exercicio3
{
    internal class TabelaDePrecos
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Os produtos que possuimos são: 1 - Cachorro Quente(R$4,00),2 - X-Salada(R$4,50),3 - X-Bacon(R$5,00)," +
                "4 - Torrada Simples(R$2,00),5 - Refrigerantes(R$1,50)");
            Console.WriteLine("Escolha seu lanche através dó código:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                Console.WriteLine("Você escolheu " + quantidade + " Cachorro Quente.Total a pagar " + quantidade * 4.00);

            }
            else if (codigo == 2)
            {
                Console.WriteLine("Você escolheu " + quantidade + " X-Salada.Total a pagar " + quantidade * 4.50);
            }
            else if (codigo == 3)
            {
                Console.WriteLine("Você escolheu " + quantidade + " X-Bacon.Total a pagar " + quantidade * 5.00);


            }
            else if (codigo == 4)
            {
                Console.WriteLine("Você escolheu " + quantidade + " Torrada Simples.Total a pagar " + quantidade * 2.00);

            }
            else if (codigo == 5)
            {
                Console.WriteLine("Você escolheu" + quantidade + "refrigerante.Total a pagar " + quantidade * 1.50);

            }
            else
            {
                Console.WriteLine("Você digitou um código inválido");

            }




        }
    }
}

/*Com base na tabela de preços ao lado (tabela fornecida no exercicio), faça
um programa que leia o código de um item e a
quantidade deste item. A seguir, calcule e
mostre o valor da conta a pagar.*/
