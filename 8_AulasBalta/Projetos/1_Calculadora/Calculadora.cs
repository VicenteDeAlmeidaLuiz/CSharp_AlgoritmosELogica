using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta.Projetos._1_Calculadora
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Qual a operação matemática você deseja executar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("______________________");
            Console.WriteLine("Digite sua operação:");
            short operacao = short.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Sair(); break;
                default: ValoInvalido(); break;

            }


        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número:");
            double primeiroNumero = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double segundoNumero = double.Parse(Console.ReadLine());

            double resultado = primeiroNumero + segundoNumero;

            Console.WriteLine($"O resultado da soma é {resultado}.");
            Menu();


        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            double primeirValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double segundoValor = double.Parse(Console.ReadLine());
            double resultadoSubtracao = primeirValor - segundoValor;
            Console.WriteLine($"O resultado da subtração é {resultadoSubtracao}.");
            Console.ReadKey(); /*O readkey não encerra o programa após toda a execução*/
            Menu();

        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            double primeirValorDivisao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double segundoValorDivisao = double.Parse(Console.ReadLine());
            double resultadoDivisao = primeirValorDivisao / segundoValorDivisao;
            Console.WriteLine($"O resultado da divisão é {resultadoDivisao}.");
            Console.ReadKey(); /*O readkey não encerra o programa após toda a execução*/
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            double primeirValorMultiplicacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double segundoValorMultiplicacao = double.Parse(Console.ReadLine());
            double resultadoMultiplicaco = primeirValorMultiplicacao * segundoValorMultiplicacao;
            Console.WriteLine($"O resultado da multiplicação é {resultadoMultiplicaco}.");
            Console.ReadKey(); /*O readkey não encerra o programa após toda a execução*/
            Menu();



        }

        static string ValoInvalido()
        {
            string valorInvalido = "Você digitou um valor inválido";
            Console.WriteLine(valorInvalido);
            Menu();
            return valorInvalido;

        }
        static string Sair()
        {
            string sair = "Obrigado por utilizar nossa calculadora.";
            Console.WriteLine(sair);
            System.Environment.Exit(0);
            return sair;


        }
    }
}
