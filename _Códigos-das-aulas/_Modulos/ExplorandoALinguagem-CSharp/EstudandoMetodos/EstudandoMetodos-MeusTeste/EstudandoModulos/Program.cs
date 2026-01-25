using EstudandoModulos.Models;

Console.Clear();

CheckLogin login = new();

string? nivelUser = "invalido";
bool loginValid = false;

nivelUser = login.Logar();
loginValid = login.VerifiqueLogin();
while (!loginValid)
{
    Console.WriteLine(
        "....................\n"+
        "-  Login invalido  -\n"+
        "....................\n"
    );
    nivelUser = login.Logar();
    loginValid = login.VerifiqueLogin();
}

int loginInvalido = 0;
while (loginValid)
{
    switch(nivelUser)
    {
        case "admin":
            if (loginInvalido == 0)
            {
                login.PrivilegiosDeAdm();
            }
            break;
        case "professor":
            break;
        case "aluno":
            if (loginInvalido == 0)
            {
                login.PrivilegiosDeAluno();
            }
            break;
        default:
            Console.WriteLine("\t-Login não é valido.");
            loginValid = false;
            break;
    }
    nivelUser = login.Logar();
    loginValid = login.VerifiqueLogin();
    if (loginValid == false && nivelUser != "invalido" && nivelUser != "fim")
    {
        Console.WriteLine(
            "....................\n"+
            "-  Login invalido  -\n"+
            "....................\n"
        );
        loginValid = true;
        loginInvalido = 1;
    } else
    {
        loginInvalido = 0;
    }
}
