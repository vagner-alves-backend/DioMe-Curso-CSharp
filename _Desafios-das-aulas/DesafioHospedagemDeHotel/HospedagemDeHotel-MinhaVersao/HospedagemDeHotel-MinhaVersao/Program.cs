using HospedagemDeHotel_MinhaVersao.Models;

Recepcionista recepcao = new();

recepcao.GetReservasJson();
Console.Clear();
recepcao.GetHospedesJson();
recepcao.NumeroRegistroAtual();

int suites = 5;
string? opcao = "";
bool _continue = true;
while (_continue)
{
    Console.Write(
        "\t-- Deseja...\n"+
        "[1] Criar uma reserva\n"+
        "[2] Pesquisar por uma reserva\n"+
        "[3] Ver Todas as reservas\n"+
        "[4] Remover uma reserva\n"+
        "[5] Finaliza o programa\n"+
        "--> "
    );
    opcao = Console.ReadLine();
    Console.Clear();
    switch (opcao)
    {
        case "1":
            if (recepcao.ObterQuantidadeDeHospedes() < suites)
            {
                recepcao.DadosHospede();
                Console.Clear();
            } else
            {
                Console.WriteLine("Não há suítes disponíveis no momento.");
            }
            break;
        case "2":
            recepcao.PesquisarReserva();
            break;
        case "3":
            recepcao.ListaDeHospedes();
            break;
        case "4":
            recepcao.RemoverRegistro();
            break;
        case "5":
            _continue = false;
            break;
        default:
            Console.WriteLine("Opcão não encontrada, favor informe uma opção valida.");
            break;
    }
}
Console.Clear();
recepcao.SetReservasJson();
