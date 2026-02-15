using HospedagemDeHotel_MinhaVersao.Models;

Recepcionista recepcao = new();
do
{
    Console.Clear();
    recepcao.DadosHospede();
} while (recepcao.ObterQuantidadeDeHospedes() != 1);
recepcao.ListaDeHospedes();
