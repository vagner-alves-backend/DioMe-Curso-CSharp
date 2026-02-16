using HospedagemDeHotel_MinhaVersao.Models;

Recepcionista recepcao = new();

recepcao.GetReservasJson();
Console.Clear();
recepcao.GetHospedesJson();

int suites = 5;
string? registrarMaisUm = "";
while (recepcao.ObterQuantidadeDeHospedes() < suites)
{
    Console.Clear();
    Console.Write(
        "---Deseja Registrar uma nova reserva?\n"+
        "[1] Sim\n"+
        "[2] Não..: "
    );
    registrarMaisUm = Console.ReadLine();
    Console.Clear();

    if (registrarMaisUm == "1")
    {
        recepcao.DadosHospede();
    } else
    {
        suites = -1;
    }
}
Console.Clear();
recepcao.SetReservasJson();
recepcao.ListaDeHospedes();
