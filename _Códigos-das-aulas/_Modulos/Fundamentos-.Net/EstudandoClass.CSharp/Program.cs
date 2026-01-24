using _Classes.Models;


//      Indica os valores iniciais...
Pessoa pessoa = new()
{
  Nome = "Vágner",
  Idade = 20
};

pessoa.Apresentar();


//      Altera os valores definidos no inicio...
pessoa.Nome = "Gustavo";
pessoa.Idade = 23;
pessoa.Apresentar();
