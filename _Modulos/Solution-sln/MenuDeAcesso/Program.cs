
string? opcaoSelecionada = "null";
bool opcaoValida = true;
do
{
    Console.WriteLine("-------Login------\n"+
                      "[1] Cliente\n"+
                      "[2] Adimin");
    opcaoSelecionada = Console.ReadLine();
    if (opcaoSelecionada == "1" || opcaoSelecionada == "2")
    {
        opcaoValida = true;
    } else
    {
        opcaoValida = false;
        Console.WriteLine("\tOpção não encontrada, favor informe uma opção valida...");
    }
} while (!opcaoValida);
