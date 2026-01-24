using lacosRepeticao.Models;

string? numeroInformado = "null";
bool valorValido = true;
int numeroInvalido = 0;
int numeroDeContagem = 0;
do
{
    Console.WriteLine("Informe um número...");
    numeroInformado = Console.ReadLine();
    valorValido = int.TryParse(numeroInformado, out numeroInvalido);

    if (valorValido == false)
    {
        Console.WriteLine("\t[ERRO]: Valor invalido, informe um valor valido...");
    }
} while (!valorValido);
numeroDeContagem = Convert.ToInt32(numeroInformado);
Console.WriteLine("..........\n");

LacosDeRepeticao laco  = new()
{
    Contador = numeroDeContagem
};
laco.RepeticaoComFor();
laco.RepeticaoComWhile();
