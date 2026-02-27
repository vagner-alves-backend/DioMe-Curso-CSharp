using System.ComponentModel;
using System.Diagnostics;
using DesafioAbstraindoUmCelular_POO.Models;

Console.Clear();
IUSmartphone smartphone = new ();
smartphone.Desserializacao();

bool _continue = true;
string? opcao = "";
do
{ 
    Console.Write(
        "--Deseja...\n"+
        "\t1 °Acessar contato\n"+
        "\t2 °Registrar contato\n"+
        "\t3 °Encerrar programa\n"+
        "--> "
    );
    opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1": smartphone.AcessarSmartphone(); break;
        case "2": smartphone.AddSmartphone(); break;
        case "3": _continue = false; break;
        default:
            Console.WriteLine("-- Opção não encontrada... --");
            break;
    }
} while (_continue);
