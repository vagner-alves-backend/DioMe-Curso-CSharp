using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _Classes.Models
{
    public class Pessoa //        Classe...
    {
        public string? Nome { get; set; }
        public int? Idade { get; set; }

        public void Apresentar() //     Método --- Função...
        {
            Console.WriteLine($"Meu nome é {Nome}, e eu tenho {Idade}...");
        }
    }
}
