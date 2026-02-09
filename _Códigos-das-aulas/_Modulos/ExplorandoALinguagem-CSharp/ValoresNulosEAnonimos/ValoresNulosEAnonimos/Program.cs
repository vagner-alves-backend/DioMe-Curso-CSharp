using System.Text.Json.Serialization;
using Newtonsoft.Json;
using ValoresNulosEAnonimos.Models;

// bool? isNull = null;
//isNull.HasValue == Nesse cenario se o valor for null, ele irá retornar false.

// if (!isNull.HasValue)
// {
//     Console.WriteLine("Value null.");
// } else
// {
//     Console.WriteLine($"Value is {isNull}.");
// }

string filepath = "C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Códigos-das-aulas\\_Modulos\\ExplorandoALinguagem-CSharp\\ValoresNulosEAnonimos\\ValoresNulosEAnonimos\\Arquivos\\registros.json";
// Console.WriteLine($"O valor é {(isNull.HasValue ? isNull: "Null")}.");

// List<Pessoa> pessoas = [
//     new("Vágner", "Alves", 20),
//     new("Lucas", "Souza", 24),
//     new("Sabrine", "Lopes", 19),
//     new("Laura", "Martins", 18)
// ];

// string? pessoasjson = JsonConvert.SerializeObject(pessoas, Formatting.Indented);
// File.WriteAllText(filepath, pessoasjson);
// Console.WriteLine(pessoasjson);

string filejson = File.ReadAllText(filepath);
List<Pessoa> trasPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(filejson) ?? [];
var listAnonimo = trasPessoas.Select(x => new {x.Name, x.Idade});

// foreach (var json in trasPessoas)
// {
//     Console.WriteLine($"Nome: {json.Name} {json.SobreNome}\nIdade: {json.Idade}");
// }

foreach (var element in listAnonimo)
{
    Console.WriteLine($"{element.Name} tem {element.Idade} anos.");
}

dynamic variavel = "string";
variavel = 1;
