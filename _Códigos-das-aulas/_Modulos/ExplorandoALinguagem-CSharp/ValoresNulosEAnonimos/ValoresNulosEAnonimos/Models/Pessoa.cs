using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Formats.Tar;
using System.Linq;
using System.Threading.Tasks;

namespace ValoresNulosEAnonimos.Models
{
    public class Pessoa
    {
        public string? Name { get; set; }
        public string? SobreNome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string? name, string? sobrenome, int idade)
        {
            this.Name = name;
            this.SobreNome = sobrenome;
            this.Idade = idade;
        }
    }
}