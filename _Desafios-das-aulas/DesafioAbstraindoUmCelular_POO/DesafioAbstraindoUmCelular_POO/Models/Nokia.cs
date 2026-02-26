using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public class Nokia : Smartphone
    {
        private List<string?> _app = [];
        public Nokia (string? number, string? modelo, string? imei, int memoria) : base (number, modelo, imei, memoria) {}
        public sealed override void InstalarAplicativo(string? nameApp)
        {
            Console.Clear();
            Console.Write(
                "-- Deseja Instalar o app --\n"+
                "[1] Sim              [2] Não\n"+
                "--> "
            );
            string? opcao = Console.ReadLine();
            if (opcao == "1")
            {
                _app.Add(new(nameApp));
                Console.WriteLine(".................................");
                Console.WriteLine("\tO app foi instalado...");
            } else
            {
                Console.WriteLine(".................................");
                Console.WriteLine("\tO app não foi instalado...");
            }
            Console.WriteLine("---------------------------------");
        }   
        public List<string?> GetApp() => _app;
    }
}