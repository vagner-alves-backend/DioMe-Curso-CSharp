using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public class IUSmartphone : DataBase
    {
        private string? _number;
        private string? _modelo;
        public void Registrar_smartphone()
        {
            Console.Clear();
            string? imei = "";
            string? memoriaText = "";

            Console.Write(
                "\t---Registre Smartphone...\n"+
                "Número: "
            );
            _number = Console.ReadLine();
            Console.Write(
                "      --- Modelo ---\n"+
                "[1] Nokia        [2] iPhone\n"+
                "--> "
            );
            _modelo = Console.ReadLine() switch
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
            
            AdicionarSmartphone(_number, _modelo, imei, memoria);
        }
        public void Logar_smartphone()
        {
            Console.Clear();
            Console.Write(
                "--Informe seu dados... --\n"+
                "[1] Nokia      [2] iPhone\n"+
                "--> "
            );
            _modelo = Console.ReadLine() switch
            {
                "1" => "Nokia",
                "2" => "iPhone",
                _ => "NaN"
            };
            Console.Write("Número: ");
            _number = Console.ReadLine();
            Console.WriteLine("-------------------------------");

            bool logar = _modelo switch
            {
                "Nokia" => BusqueNokia(_number),
                "iPhone" => BusqueiPhone(_number),
                _ => false  
            };

            if (logar)
            {
                Logado();
            }
        }
        private void Logado ()
        {
            Console.Clear();
            bool continuar = true;
            do
            {
                Console.Write(
                    "--Deseja...\n"+
                    "\t1 °Checar caixa postal\n"+
                    "\t2 °Checar os apps instalados\n"+
                    "\t3 °Instalar um app\n"+
                    "\t4 °Fazer uma ligação\n"+
                    "\t5 °Deslogar\n"+
                    "--> "
                );
                string? opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        CaixaPostal();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        LigarUI();
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada.");
                        break;
                }
            } while (continuar);
            Console.Clear();
        }
        private void CaixaPostal ()
        {
            List<(string? modelo, string? number)> caixaPostal = GetCaixaPostal(_modelo, _number);
            if (caixaPostal.Count != 0)
            {
                Console.WriteLine("\t--Ligações perdidas de...");
                foreach ((string? modelo, string? number) in caixaPostal)
                {
                    Console.WriteLine($"{modelo} - {number}");
                }
                Console.WriteLine("--------------------------------");
            }
        }
        private void LigarUI()
        {
            Console.Clear();
            Console.Write(
                " ---Deseja ligar para...\n"+
                "[1] Nokia      [2] iPhone\n"+
                "--> "
            );
            string? modelo = Console.ReadLine() switch
            {
                "1" => "Nokia",
                "2" => "iPhone",
                _ => "NaN"
            };
            Console.Write("Número: ");
            string? number = Console.ReadLine();
            Console.WriteLine("--------------------------");

            bool ligou = false;
            
            
            if (ligou)
            {
                Console.WriteLine("\t--- A ligação feita com sucesso... ---");
                Serializacao();
                Desserializacao();
            } else
            {
                Console.WriteLine("\t--- Não foi possível completar a ligação... ---");
            }
        }

    }
}
