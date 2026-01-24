using TiposDeDados.Modelos;

//      Passando dados para class..
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

//      Convertendo dados..
string text = "5c";
int num = 0;
bool conversao = int.TryParse(text, out num);

Console.WriteLine($"\nA conversão de tipo foi feita: {conversao}");

if (conversao == true)
{
    Console.WriteLine($"---A string foi convertida com sucesso...[{num}]");
} else
{
    Console.WriteLine($"---Deu algum erro durante a conversão, valor inrregular [{text}]");
}

//      Operadores condicionais...
int estoque = 10;
int pedido = 11;
if (estoque >= pedido)
{
    Console.WriteLine($"Um pedido de {pedido} itens, Foi aprovado...");
} else
{
    Console.WriteLine($"\nNão temos a quantidade desejada em estoque.\n"+
                      $"No momento temos apenas {estoque} itens em estoque\nse quiser podemos fazer uma encomenda para cobrir o(s) {pedido - estoque} itens faltando..\n");
}
