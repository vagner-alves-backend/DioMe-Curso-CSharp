using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemDeHotel_MinhaVersao.Models
{
    public class NotasDasReservas(string? name, string? sobrename, string? suite,int quantidadeSuites, int quantidadePessoas, int diasReservados, int numeroDoRegistro, decimal valorTotal)
    {
        public string? Nome = name;
        public string? Sobrenome = sobrename;
        public string? Suite = suite;
        public int QuantidadeSuites = quantidadeSuites;
        public int QuantidadePessoas = quantidadePessoas;
        public int DiasReservados = diasReservados;
        public int NumeroDoRegistro = numeroDoRegistro;
        public decimal ValorTotal = valorTotal;
        public NotasDasReservas() : this ("NaN", "NaN", "NaN", 0, 0, 0, 0, 0) {}
    }
}
