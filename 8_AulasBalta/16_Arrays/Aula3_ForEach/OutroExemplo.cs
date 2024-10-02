using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._16_Arrays.Aula3_ForEach
{
    internal class OutroExemplo
    {
        static void Main(string[] args)
        {
            var arrayInt = new int[5] { 1, 2, 3, 4, 5 };
            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2578, Nome = "Vicente" };
            funcionarios[1] = new Funcionario() { Id = 2579, Nome = "Marcelo" };
            funcionarios[2] = new Funcionario() { Id = 2580, Nome = "Vinicius" };
            funcionarios[3] = new Funcionario() { Id = 2581, Nome = "André" };
            funcionarios[4] = new Funcionario() { Id = 2582, Nome = "Roberto" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);

            }



        }

        public struct Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }

        }
    }
}
