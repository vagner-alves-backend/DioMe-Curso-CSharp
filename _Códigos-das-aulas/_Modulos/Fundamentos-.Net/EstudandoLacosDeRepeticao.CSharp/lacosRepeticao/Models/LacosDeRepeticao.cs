using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lacosRepeticao.Models
{
    public class LacosDeRepeticao
    {
        public int Contador {get; set;}
        public void RepeticaoComFor()
        {
            for (int index = 0; index <= Contador; index++)
            {
                Console.WriteLine($"{index} ");
            }
            Console.WriteLine("Fim de contagem com for...");
        }

        public void RepeticaoComWhile()
        {
            int cont = 0;
            while (cont <= Contador)
            {
                Console.WriteLine($"{cont} ");
                cont++;
            }
            Console.WriteLine("Fim de cotagem com While...");
        }
    }
}
