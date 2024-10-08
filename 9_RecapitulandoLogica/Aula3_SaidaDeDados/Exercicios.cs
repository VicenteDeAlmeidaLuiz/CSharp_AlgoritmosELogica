﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.RecapitulandoLogica.Aula3_SaidaDeDados
{
    internal class Exercicios
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1},cujo preço é R$ {preco1:F2}.");
            Console.WriteLine($"{produto2},cujo preço é R$ {preco2:F2}.");
            Console.WriteLine($"Registro: {idade} anos de idade,código {codigo} e genêro: {genero}.");
            Console.WriteLine($"Medida com oito casas decimais {medida:F8}.");
            Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}.");
            Console.WriteLine($"Separador decimal invariant culture:{medida.ToString("F3", CultureInfo.InvariantCulture)}");


        }
    }
}
