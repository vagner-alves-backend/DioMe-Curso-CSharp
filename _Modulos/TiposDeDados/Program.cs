using TiposDeDados.Modelos;

Dados typeDados = new()
{
    Nome = "Vágner",
    Inteiro = 20,
    Floate = 2.5F,
    Double = 2.30,
    Byte = 13,
    Decimal = 0.456M,
    Boleano = true
};

 typeDados.EscrevaDados();

//      Teste de data e hora 
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine($"Hora - {dataAtual.ToString("HH")}\nMinutos - {dataAtual.ToString("mm")} \nDia - {dataAtual.ToString("dd")}\nMês - {dataAtual.ToString("MM")}\nAno - {dataAtual.ToString("yyyy")}");
