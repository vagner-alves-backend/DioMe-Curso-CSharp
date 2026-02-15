using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemDeHotel_MinhaVersao.Models
{
    public class Pessoa(string? name, string? sobrenome)
    {
        public string? Name = name;
        public string? Sobrenome = sobrenome;
        public Pessoa() : this ("NaN", "NaN") {}
    }
}
