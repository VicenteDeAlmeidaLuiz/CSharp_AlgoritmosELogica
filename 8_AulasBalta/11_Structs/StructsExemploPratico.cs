using System;

namespace AlgoritmosELogicaCsharp.AulasBalta._11_Structs
{
    internal class StructsExemploPratico
    {
        static void Main(string[] args)
        {
            ProdutoServico carro = new ProdutoServico(58, "Palio", 58.000); /*Ao innstanciar eu tenho a opção de passar os parâmetros do construtor ou não*/
            Console.WriteLine("O id do carro é: " + carro.Id);
            Console.WriteLine("O nome do carro é: " + carro.Nome);
            Console.WriteLine("O valor do carro é: " + carro.Preco.ToString("F3"));


        }
    }
}
struct ProdutoServico
{
    public ProdutoServico(int id, string nome, double preco)
    {

        Id = id;
        Nome = nome;
        Preco = preco;

    } /*Aqui é o que chamamos de construtor,um método com o mesmo nome da classe*/
    public int Id;
    public string Nome;
    public double Preco; /*Convenção: Propriedade sempre em maíusculo e parâmetro de método sempre em minúsculo*/

    public double precoEmDolar(double dolar)
    {
        return Preco * dolar;
    }



}
/*Structs devem ser criados fora da classe e fora do método Main,mas dentro do namespace*/
