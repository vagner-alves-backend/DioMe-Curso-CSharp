using ClassGenericas.Models;

MeuArray<string?> arrayString = new();
MeuArray<int> arrayInteiro = new();

arrayString.AddNewElement("Vágner Alves");
arrayInteiro.AddNewElement(20);

Console.Clear();
Console.WriteLine($"{arrayString[0]} tem {arrayInteiro[0]} anos.");
Console.ReadLine();
