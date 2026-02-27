using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public class Nokia : Smartphone
    {
        public List<(string? modelo, string? number)> CaixaPostal = [];
        public List<string?> Aplicativos = [];

        public Nokia (string? numero, string? modelo, string? imei, int memoria) : base (numero, modelo, imei, memoria) {}

        public sealed override void ReceberLigacao(string? modelo, string? numero) => CaixaPostal.Add(new(modelo, numero));
        public void PrintCaixaPostal ()
        {
            if (CaixaPostal.Count != 0)
            {
                Console.WriteLine("--- As ligações perdidas são...");
                foreach ((string? modelo, string? number) in CaixaPostal)
                {
                    Console.WriteLine($"\t{modelo} - {number}");
                }
                Console.WriteLine("-------------------------------");
            } else
            {
                Console.WriteLine("-- Não a ligações perdidas no momento... --");
            }
        }
        public void PrintAplicativos ()
        {
            if (Aplicativos.Count != 0)
            {
                Console.WriteLine("--- Os aplicativos instalados são...");
                foreach (string? app in Aplicativos)
                {
                    Console.WriteLine(app);
                }
                Console.WriteLine("-------------------------------");
            } else
            {
                Console.WriteLine("-- Não a aplicativos instalados no momento... --");
            }
        }
        public sealed override void InstalarAplicativo(string? nameApp)
        {
            if (!string.IsNullOrWhiteSpace(nameApp))
            {
                Aplicativos.Add(new(nameApp));
            } else
            {
                Console.WriteLine("Favor informe o nome do aplicativo que deseja instalar.");
            }
        }
    }
}