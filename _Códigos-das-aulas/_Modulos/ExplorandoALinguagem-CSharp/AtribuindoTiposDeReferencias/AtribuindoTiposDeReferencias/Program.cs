using AtribuindoTiposDeReferencias.Models;

Pessoa pessoa1 = new("Vágner", "Alves");
Pessoa pessoa2 = pessoa1;
pessoa2.Name = "Lucas"; // Como não foi usado o termo [ new() ], o valor de ambas serão alterados.
Console.WriteLine(
    $"Name 1 = {pessoa1.Name}\n"+
    $"Nome 2 = {pessoa2.Name}"
);
