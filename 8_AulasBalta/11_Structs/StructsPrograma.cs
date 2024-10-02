using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._11_Structs
{
    internal class StructsPrograma
    {






    }
}

struct Produto
{
    /*Aqui dentro propriedades e métodos*/

    public int Id; /*Aqui é a propriedade,atributo do produto (Produto tem um ID)*/
    public float Preco;

    public float PrecoEmDolar(float dolar)
    {
        return Preco * dolar; /*Aqui o método para calcular o valor em dólar (exemplo)*/
    }

}


/*Tipo de dado estruturado,é apenas a estrutura,o esqueleto.
 Armazenam outros tipos de dados e é definido pela palavra struct.
Composto de propriedades e métodos.
Nome sempre em maíusculo (o mesmo para propriedades e métodos)
Criado a partir da palavra new e nesse momento temos valores
Criado fora da classe*/
