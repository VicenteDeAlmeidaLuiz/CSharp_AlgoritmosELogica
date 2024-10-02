using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._12_Enums
{
    internal class EnumsPrograma
    {
        static void Main(string[] args)
        {

            ProdutoServico carro = new ProdutoServico(58, "Palio", 58.000d, ETipoProduto.Produto);
            ProdutoServico manutencao = new ProdutoServico(95, "Manutenção Elétrica", 400, ETipoProduto.Servico);
            Console.WriteLine("O id do carro é: " + carro.Id);
            Console.WriteLine("O nome do carro é: " + carro.Nome);
            Console.WriteLine("O valor do carro é: " + carro.Preco.ToString("F3"));
            Console.WriteLine("Esse carro é do tipo: " + carro.Tipo);
            Console.WriteLine("Esse carro é do tipo: " + (int)carro.Tipo);
            /*Para apresentar o valor do enum eu faço a conversão explícita dele*/
            Console.WriteLine("___________________________");
            Console.WriteLine("O id do serviço é " + manutencao.Id);
            Console.WriteLine("O tipo de manutenção é: " + manutencao.Nome);
            Console.WriteLine("O valor da manutenção é: " + manutencao.Preco);
            Console.WriteLine("Essa manuteção é do tipo: " + manutencao.Tipo);
            Console.WriteLine("Essa manuteção é do tipo: " + (int)manutencao.Tipo);



        }
    }
    struct ProdutoServico
    {
        public ProdutoServico(int id, string nome, double preco, ETipoProduto tipo)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Tipo = tipo;




        }

        public int Id;
        public string Nome;
        public double Preco;
        public ETipoProduto Tipo;



        public double precoemDolar(double dolar)
        {

            return Preco * dolar;

        }

    }
    enum ETipoProduto
    {
        Produto = 1,
        Servico = 2
    }
}
/*Enums ou enumeradores são usados para fornecer uma melhor visualização do código.
 Substituem o uso de inteiros.
Usados em listas curtas.
Usados em dados fixos.
Sempre em maiúsculo e começar com a letra E*/
