using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._6_OperadoresLogicos
{
    internal class OperadoresLogicos
    {
        static void Main(string[] args)
        {
            /*Usados em operações condicionais.
             Retorna sempre verdadeiro ou falso
            E - and
            && - e: Deve atender todas as condições

                OU - or - Se atender uma condição já retorna verdadeiro ||

                Negação - not !
             */

            int x = 25;
            bool entre = (x > 25) && (x < 40); //False pq deve atender as duas condições
            bool ou = (x > 25) || (x < 40); //True pq somente uma das cond~ições deve ser verdadeira
            bool negacao = !(x < 25); //True pq na negação é False mas como ta negando a condição ai retorna ao contrário

            Console.WriteLine(entre);
            Console.WriteLine(ou);
            Console.WriteLine(negacao);
        }
    }
}
