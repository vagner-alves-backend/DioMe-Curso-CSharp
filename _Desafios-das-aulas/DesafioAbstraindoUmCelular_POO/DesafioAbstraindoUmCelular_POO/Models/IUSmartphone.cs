using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public class IUSmartphone : Json
    {
        private string? _number;
        private string? _modelo;
        private string? _imei;
        private int _memoria;

        public void AddSmartphone ()
        {
            Console.Clear();
            Console.Write(
                "---Informe os dados do aparelho que deseja adicionar ao sistema..\n"+
                "--     Modelo    --\n"+
                "[1] Nokia  [2] iPhone\n"+
                "--> "
            );
            this._modelo = Console.ReadLine() switch
            {
                "1" => "Nokia",
                "2" => "iPhone",
                _ => "NaN"
            };
            Console.Write("Number: ");
            this._number = Console.ReadLine();
            Console.Write("IMEI: ");
            this._imei = Console.ReadLine();
            Console.Write("Mémoria: ");
            this._memoria = int.TryParse(Console.ReadLine(), out int memoriaInt) ? memoriaInt : 0;

            try
            {
                AdicionarSmartphone (_number, _modelo, _imei, _memoria);
                Serializacao();
            } catch (Exception ex)
            {
                Console.WriteLine($"[Erro]: {ex.Message}");
            }
        }
        public void AcessarSmartphone ()
        {
            Console.Clear();
            Console.Write(
                "---Informe os dados do smartphone...\n"+
                "--     Modelo    --\n"+
                "[1] Nokia  [2] iPhone\n"+
                "--> "
            );
            this._modelo = Console.ReadLine() switch
            {
                "1" => "Nokia",
                "2" => "iPhone",
                _ => "NaN"
            };
            Console.Write("Number: ");
            this._number = Console.ReadLine();

            if (AcessarSmartphone(_modelo, _number))
            {
                MenuSmartphone();
            } else
            {
                Console.WriteLine("Não foi possível acessar o smartphone.");
            }
        }
        private void MenuSmartphone ()
        {
            Console.Clear();
            bool _continue = true;
            string? opcao = "";
            do
            {
                Console.Write(
                    "---Menu do aparelho...\n"+
                    "\t1 °Ligar para contato\n"+
                    "\t2 °Ligações perdidas\n"+
                    "\t3 °Instalas Aplicativo\n"+
                    "\t4 °Aplicativos instalados\n"+
                    "\t5° Deslogar\n"+
                    "--> "
                );
                opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1": 
                        Ligar (_modelo, _number); 
                        break;
                    case "2": ChequeCaixaPostal (_modelo, _number); break;
                    case "3": InstalarAplicativo (); break;
                    case "4": ChequeAplicativosInstalados (_modelo, _number); break;
                    case "5": _continue = false; break;
                    default:
                        Console.WriteLine("-- Opção não encontrada. --");
                        break;
                }
            } while (_continue);
        }
        private void InstalarAplicativo ()
        {
            Console.Clear();
            Console.Write("-- Name do aplicatico: ");
            string? nameApp = Console.ReadLine();
            InstalarAplicativo (_modelo, _number, nameApp);
        }
    }
}
