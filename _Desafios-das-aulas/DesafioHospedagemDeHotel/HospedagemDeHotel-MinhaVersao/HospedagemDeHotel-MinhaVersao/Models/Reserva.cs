using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemDeHotel_MinhaVersao.Models
{
    public class Reserva
    {
        private readonly List<Pessoa> _hospedes = [];
        protected List<NotasDasReservas> _notas = [];
        private Suite _suite = new();

        protected void CadastrarHospedes(Pessoa hospede) => _hospedes.Add(hospede);
        protected List<Pessoa> GetHospedes() => _hospedes;
        protected void CadastrarSuite(Suite suite) => _suite = suite;
        public int ObterQuantidadeDeHospedes() => _hospedes.Count;
        public void SetNota(NotasDasReservas notas) => _notas.Add(notas);
        public List<NotasDasReservas> GetReservas() => _notas;
        public void GetReservasJson() => _notas = Json.Deserializacao(); 
        public void SetReservasJson() => Json.Serializacao(_notas);
        public void GetHospedesJson()
        {
            foreach (NotasDasReservas reservas in _notas)
            {
                _hospedes.Add(new(reservas.Nome, reservas.Sobrenome));
            }
        }
    }
}
