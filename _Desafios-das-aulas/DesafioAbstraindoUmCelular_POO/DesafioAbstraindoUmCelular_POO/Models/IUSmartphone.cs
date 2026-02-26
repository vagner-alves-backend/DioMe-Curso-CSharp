using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public class IUSmartphone : DataBase
    {
        public void Registrar_smartphone()
        {
            Console.Clear();

            string? number = "";
            string? modelo = "";
            string? imei = "";
            string? memoriaText = "";

            Console.Write(
                "\t---Registre Smartphone...\n"+
                "Número: "
            );
            number = Console.ReadLine();
            Console.Write(
                "\t-- Modelo --\n"+
                "[1] Nokia   [2] iPhone\n"+
                "--> "
            );
            modelo = Console.ReadLine() switch
            {
                "1" => "Nokia",
                "2" => "iPhone",
                _ => ""
            };
            Console.Write("IMEI: ");
            imei = Console.ReadLine();
            Console.Write("Mémoria: ");
            memoriaText = Console.ReadLine();
            if (!int.TryParse(memoriaText, out int memoria))
            {
                memoria = 0;
            }

            AdicionarSmartphone(number, modelo, imei, memoria);
        }
    }
}