using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemDeHotel_MinhaVersao.Models
{
    public class Suite(string? tiposuite, int capacidade, decimal valordiaria)
    {
        public string? Tiposuite = tiposuite;
        public int Capacidade = capacidade;
        public decimal Valordiaria = valordiaria;
        public Suite() : this ("Master", 5, 149.99M) {}
    }
}
