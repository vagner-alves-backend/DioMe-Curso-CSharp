using ModelsClass.Common.Models;

string? opcaoSelecionada = "null";
bool opcaoValida = true;

string? nome = "null";
string? senhaCheck = "null";
bool loginValido = true;
int loginNaoValido = 0;
int senha = 0;

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

Login login = new();
if (opcaoSelecionada == "1")
{
    login.Name = "Lucas";
    login.Senha = 1234;
    login.User = 2;
} else
{
    login.Name = "Vágner";
    login.Senha = 4321;
    login.User = 1;
}

do
{
    Console.WriteLine("Nome: ");
    nome = Console.ReadLine();
    do
    {
        Console.WriteLine("Senha: ");
        senhaCheck = Console.ReadLine();
        loginValido = int.TryParse(senhaCheck, out loginNaoValido);
        if (loginValido == false)
        {
            Console.WriteLine("\tSenha invalida, apenas valores inteiros são permitidos.");
        }
    } while (!loginValido);
    senha = Convert.ToInt32(senhaCheck);
} while (!loginValido);

login.LoginUser(nome, senha);
