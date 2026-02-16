using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemDeHotel_MinhaVersao.Models
{
    public class Recepcionista : Reserva
    {
        private readonly Pessoa _registro = new();
        private readonly Suite _suite = new();
        private int dias = 0;
        private int _quantidadeDePessoas = 0;
        private int _quantidadeSuites = 1;
        private readonly decimal _valorSuite = 149.99M;
        private decimal _valorTotal = 0;
        public void DadosHospede()
        {
            Console.WriteLine("--Informe dados de cadastro do hospede...");
            Console.Write("Name..: ");
            _registro.Name = Console.ReadLine();
            Console.Write("Sobrenome..: ");
            _registro.Sobrenome = Console.ReadLine();
            bool reservaConcluida = DadosDaReserva();
            if (reservaConcluida)
            {
                CadastrarHospedes(new(_registro.Name, _registro.Sobrenome));
                CalcularValorTotal();
                SetNota(new(_registro.Name, _registro.Sobrenome, _suite.Tiposuite, _quantidadeSuites, _quantidadeDePessoas, dias, _valorTotal));
            }
        }
        private bool DadosDaReserva()
        {
            bool reservaValida = true;
            Console.Clear();
            Console.WriteLine("\t--Dados da reserva do hospede...");
            Console.Write($"Deseja reservar quantos dias senho(a) {_registro.Name} ? ");
            string? diasInfo = Console.ReadLine();
            dias = ValidNumber(diasInfo);

            Console.Write("Quantas pessoas fiaram hospedadas na suite? ");
            string? hospedesQuantidade = Console.ReadLine();
            _quantidadeDePessoas = ValidNumber(hospedesQuantidade);
            if (_quantidadeDePessoas > _suite.Capacidade)
            {
                Console.Clear();
                Console.WriteLine("\tA capacidade maxima da suite foi ultrapassada..");
                Console.Write(
                    $"--A capacidade maxima das suites é de {_suite.Capacidade} pessoas.\n"+
                    "------------------------------------------------------------------------\n"+
                    "-Deseja reservar suites para todas essas pessoas em seu registro[s/n]: "
                );
                string? remanejarPessoas = Console.ReadLine();
                if (remanejarPessoas?.ToLower() == "s")
                {
                    int quantSuites = 1;
                    for (int index = _quantidadeDePessoas; index > _suite.Capacidade; index-=5)
                    {
                        quantSuites++;
                    }
                    Console.Write($"Serão necessarias {quantSuites} suites, deseja reservalas[s/n]: ");
                    string? reservar = Console.ReadLine();
                    reservaValida = reservar?.ToLower() == "s";
                    _quantidadeSuites = quantSuites;
                } else
                {
                    reservaValida = false;
                }

                Console.Clear();
                string? reservaTexto = reservaValida ? "Reserva concluida com sucesso." : "Reserva invalida, favor tente novamente...";
                Console.WriteLine(reservaTexto);
                Thread.Sleep(2000);
            }
            return reservaValida;
        }
        private static int ValidNumber(string? valor)
        {
            int number = 0;
            do
            {
                while (!int.TryParse(valor, out _))
                {
                    Console.Clear();
                    Console.WriteLine($"[Erro]:O valor [{valor}] é invalido, favor informe um valor valido..");
                    Console.Write("--> ");
                    valor = Console.ReadLine();
                }
                number = Convert.ToInt32(valor);
                if (number <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Valor minimo permitido não atingido.");
                    Console.Write("Favor informe uma quantidade valida..: ");
                    valor = Console.ReadLine();
                }
            } while (number <= 0);

            return number;
        }
        public void ListaDeHospedes()
        {
            Console.WriteLine("----Essa é a lista de hospedes presentes no hotel..: ");
            foreach(NotasDasReservas reserva in GetReservas())
            {
                Console.WriteLine(
                    $"Nome:                  {reserva.Nome} {reserva.Sobrenome}\n"+
                    $"Suite:                 {reserva.Suite}\n"+
                    $"Quantidade de suites:  {reserva.QuantidadeSuites}\n"+
                    $"Quantidade de pessoas: {reserva.QuantidadePessoas}\n"+
                    $"Dias reservados:       {reserva.DiasReservados}\n"+
                    $"Valor total:           {reserva.ValorTotal:C}\n"+
                    "..........................................."
                );
            }
            Console.WriteLine("-----------------------------------------------------");
        }
        public void SetSuite() => DadosSuite();
        private void DadosSuite()
        {
            Console.WriteLine("--Cadastre uma suite...");
            Console.Write("Tipo da suite..: ");
            _suite.Tiposuite = Console.ReadLine();
            Console.Write("Capacidade..: ");
            string? capacidadeInfo = Console.ReadLine();
            _suite.Capacidade = ValidNumber(capacidadeInfo);
            _suite.Valordiaria = _valorSuite;

            CadastrarSuite(_suite);
        }
        public void CalcularValorTotal()
        {
            if (dias <= 10)
            {
                if (_quantidadeSuites == 1)
                {
                    _valorTotal = _valorSuite * dias;
                } else
                {
                    _valorTotal = _valorSuite * dias;
                    _valorTotal *= _quantidadeSuites;
                }
            } else
            {
                if (_quantidadeSuites == 1)
                {
                    _valorTotal = _suite.Valordiaria * dias;
                    decimal porcentagem = _valorTotal * 0.1M;
                    _valorTotal -= porcentagem;
                } else
                {
                    _valorTotal = _suite.Valordiaria * dias;
                    _valorTotal *= _quantidadeSuites;
                    decimal porcentagem = _valorTotal * 0.1M;
                    _valorTotal -= porcentagem;
                }
            }
        }
    }
}
