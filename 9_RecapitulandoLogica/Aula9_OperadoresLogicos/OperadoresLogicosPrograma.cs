using system;
using system.collections.generic;
using system.linq;
using system.text;
using system.threading.tasks;

namespace algoritmoselogicacsharp.recapitulandologica.aula9_operadoreslogicos
{
    internal class operadoreslogicosprograma
    {
        static void main(string[] args)
        {
            /*&&: e
             ||: ou
            !: não*/

            bool condicao1 = 4 != 5; /*4 diferente de cinco: true*/
            bool condicao2 = 2 > 3 && 4 != 5; /*dois diferente de 3 e 4 diferente de cinco: false pq no && as duas expressões precisam ser verdadeira*/
            bool condicao3 = 2 > 3 || 4 != 5; /*dois diferente de 3 e 4 diferente de cinco: true pq no || somente uma das duas expressões precisam ser verdadeira*/
            bool condicao4 = !(2 > 3) && 4 != 5; /*o não inverte,o que é falso fica verdadeiro e o  que é verdadeiro fica falso,nesse caso resultado true*/
            Console.WriteLine(condicao1);
            Console.WriteLine(condicao2);
            Console.WriteLine(condicao3);
            Console.WriteLine(condicao4);


        }
    }
}
