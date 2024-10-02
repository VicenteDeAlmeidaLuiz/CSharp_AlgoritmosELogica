using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosELogicaCsharp.AulasBalta._13_Strings.Aula1_Guids
{
    internal class ProgramaGuids
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); /*Guid: Global Unique identifier*/
            id.ToString();
            id = new Guid("b66f42ea-3ebf-45eb-af5b-a07dc20ec3ba");
            Console.WriteLine(id); /*Aqui ele apresenta um hash,um número grande,sempre que executa ele gera um novo número*/
            Console.WriteLine(id.ToString().Substring(0, 8));  /*Aqui eu pego somente os primeiros caracteres*/

        }
    }
}
/*Guid seria um identificador único,como se fosse um id*/