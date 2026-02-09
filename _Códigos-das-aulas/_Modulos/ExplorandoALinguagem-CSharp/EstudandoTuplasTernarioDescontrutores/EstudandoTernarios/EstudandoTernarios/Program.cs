using EstudandoTernarios.Models;
Console.Clear();

string? numberText = "";
do
{
    Console.Write("Informe um number par..: ");
    numberText = Console.ReadLine();
    Console.Clear();
    while (!int.TryParse(numberText, out _))
    {
        Console.Write("O valor informado não é um number,\nFavor informe um numbe -> ");
        numberText = Console.ReadLine();
    }

    Console.WriteLine($"O número {numberText} é {(Convert.ToInt32(numberText).EhPar() ? "par" : "Impar")}");
} while (!Convert.ToInt32(numberText).EhPar());

