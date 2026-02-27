using System.ComponentModel;
using DesafioAbstraindoUmCelular_POO.Models;

Console.Clear();
IUSmartphone smartphone = new();

bool _continue = true;
string? opcao = "";
do
{
    Console.Write(
        "\t---Deseja...\n"+
        "1 °Acessar número\n"+
        "2 °Adicionar número\n"+
        "3 °Encerrar programa\n"+
        "--> "
    );
    opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1":
            smartphone.Logar_smartphone();
            break;
        case "2":
            smartphone.Registrar_smartphone();
            break;
        case "3":
            _continue = false;
            break;
        default:
            Console.WriteLine("-- Opção não encontrada... --");
            break;
    }
} while (_continue);
