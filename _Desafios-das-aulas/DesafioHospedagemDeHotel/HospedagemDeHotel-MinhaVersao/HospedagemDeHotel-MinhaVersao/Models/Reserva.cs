using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace HospedagemDeHotel_MinhaVersao.Models
{
    public static class Reserva
    {
        private static List<Pessoa> _hospedes = [];
        private static Suite _suite = new();
        private static int _diasReservados = 0;

        public static void CadastrarHospedes()
        {
            Console.WriteLine("\t--Dados de Registro..");
            Console.Write("Name..: ");
            string? name = Console.ReadLine();
            Console.Write("Sobrenome..: ");
            string? sobrenome = Console.ReadLine();
            _hospedes.Add(new(name, sobrenome));

            bool diasValid = false;
            string? dias = "";
            do
            {
                Console.Write(
                    $"Olá {name} {sobrenome}, sejá bem vindo ao nosso Hotel!\n"+
                    "Deseja se manter hospedado por quantos dias? "
                );
                dias = Console.ReadLine();
                if (!int.TryParse(dias, out _))
                {
                    Console.Clear();
                    Console.WriteLine("\t[Erro]: Valor informado invalido.");
                    Console.WriteLine("-------------------------------------------------");
                } else if (Convert.ToInt32(dias) <= 0)
                {
                    Console.Clear();
                    Console.WriteLine(" Número minimo de dias permitidos não atingido.");
                    Console.WriteLine("-------------------------------------------------");  
                } else
                {
                    Console.Clear();
                    _diasReservados = Convert.ToInt32(dias);
                    diasValid = true;
                }
            } while (!diasValid);

            // deseja reservar uma suite ou um quarto normal.
            Console.Write("--Deseja reservar uma de nossas suites[s/n]: ");
            string? reserva = Console.ReadLine();
            if (reserva?.ToLower() == "s")
            {
                // suite
            } else
            {
                Console.WriteLine(
                    "Muito bem, seu registro foi concluido com sucesso...\n"+
                    "----------------------------------------------------\n"+
                    "\t\tRegistro---\n"+
                    $"Reserva no nome de {name} {sobrenome}\n"+
                    $"N° Quarto 102, tempo de estadia {_diasReservados} dias\n"+
                    "....................................................\n"+
                    $"Valor a ser pago {CalculaValorDiaria():C}\n"+
                    "----------------------------------------------------"
                );
            }
            /*
                número do quarto
                nome e sobrenome da pessoa
                tempo de hospedagem 
                valor da diaria
                total a ser pago
            */
        }
        public static void CadastrarSuite(Suite suite)
        {
            // nome da suite e número do quarto
            // valor da diaria
        }
        public static int ObterQuantidadeDeHospedes() => _hospedes.Count;
        public static decimal CalculaValorDiaria() => _diasReservados * 150.95M;
    }
}
