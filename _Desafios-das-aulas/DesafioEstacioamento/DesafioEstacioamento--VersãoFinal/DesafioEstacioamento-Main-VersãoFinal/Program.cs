using DesafioEstacioamento_Main_VersãoFinal.Models;
Console.Clear();

ValidNumber numberValid = new();

decimal precoInicial = 0;
decimal precoHoras = 0;

Console.Write(
    "\t- Seja bem vindo ao sistema de estacionamento...\n" +
	"Digite o preço inicial: "
);
numberValid.NumberText = Console.ReadLine();
numberValid.Valid();
precoInicial = Convert.ToDecimal(numberValid.NumberText);

Console.Write("Agora informe o preço das horas..: ");
numberValid.NumberText = Console.ReadLine();
numberValid.Valid();
precoHoras = Convert.ToDecimal(numberValid.NumberText);
