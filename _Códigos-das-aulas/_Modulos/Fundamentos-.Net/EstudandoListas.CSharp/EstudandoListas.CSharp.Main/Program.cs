List<string> listNames = [];
listNames.Add("Vágner");
listNames.Add("Lucas");
listNames.Add("Fernanda");
listNames.Add("Sara");

listNames.AddRange("Matheus", "Gustavo", "Laura", "Mariana");

foreach (string nome in listNames)
{
    Console.WriteLine(nome);
}


// string[] names = ["Vágner", "Lucas", "Marciel"];
// Array.Resize(ref names, names.Length * 2);
// Console.WriteLine(names.Length);
