using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public class DataBase
    {
        protected List<Nokia> _nokiaLIST = Json.Desserializacao_Nokia();
        protected List<IPhone> _iPhoneLIST = Json.Desserializacao_iPhone();
        public void AdicionarSmartphone(string? number, string? modelo, string? imei, int memoria)
    {
            bool valido = false;
            try
            {
                switch (modelo)
                {
                    case "Nokia":
                        _nokiaLIST.Add(new(number, modelo, imei, memoria));
                        valido = true;
                        break;
                    case "iPhone":
                        _iPhoneLIST.Add(new(number, modelo, imei, memoria));
                        valido = true;
                        break;
                    default:
                        Console.WriteLine("Não foi possível adicionar o smartphone.");
                        valido = false;
                        break;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (valido)
            {
                Serializacao();
                Desserializacao();
            }
        }
        public bool BusqueNokia (string? number) => _nokiaLIST.Any(p => p.Number == number);
        public bool BusqueiPhone (string? number) => _iPhoneLIST.Any(p => p.Number == number);
        public void InstalarAplicativo(string? modelo, string? number, string? nameApp)
        {
            if (modelo == "Nokia")
            {
                Nokia? nokia = _nokiaLIST.FirstOrDefault(p => p.Number == number);
                nokia?.App.Add(new(nameApp));
            } else if (modelo == "iPhone")
            {
                IPhone? iPhone = _iPhoneLIST.FirstOrDefault(p => p.Number == number);
                iPhone?.App.Add(new(nameApp));
            }
        }
        public List<string?> GetApp(string? modelo, string? number)
        {
            List<string?> app = [];
            if (modelo == "Nokia")
            {
                Nokia? nokia = _nokiaLIST.FirstOrDefault(p => p.Number == number);
                if (nokia != null)
                {
                    app = nokia.App;
                }
            } else if (modelo == "iPhone")
            {
                IPhone? iPhone = _iPhoneLIST.FirstOrDefault(p => p.Number == number);
                if (iPhone != null)
                {
                    app = iPhone.App;
                }
            }
            return app;
        }
        public bool Ligar (string? number, string? modelo, string? meuNumber, string? meuModelo)
        {
            bool ligacaoCompleta = modelo switch
            {
                "Nokia" => _nokiaLIST.Any(p => p.Number == number),
                "iPhone" => _iPhoneLIST.Any (p => p.Number == number),
                _ => false
            };

            if (ligacaoCompleta)
            {
                ColocarNaCaixaPostal (number, modelo, meuNumber, meuModelo);
            }

            return ligacaoCompleta;
        }
        private void ColocarNaCaixaPostal (string? number, string? modelo, string? meuNumber, string? meuModelo)
        {
            if (modelo == "Nokia")
            {
                Nokia? nokia = _nokiaLIST.FirstOrDefault(p => p.Number == number);
                nokia?.CaixaPostal.Add(new(meuModelo, meuNumber));
            } else if (modelo == "iPhone")
            {
                IPhone? iPhone = _iPhoneLIST.FirstOrDefault(p => p.Number == number);
                iPhone?.CaixaPostal.Add(new(modelo, meuNumber));
            }
        }
        public List<(string? modelo, string? number)> GetCaixaPostal (string? modelo, string? number)
        {
            List<(string? modelo, string? number)> caixaPostal = [];
            if (modelo == "Nokia")
            {
                Nokia? nokia = _nokiaLIST.FirstOrDefault(p => p.Number == number);
                if (nokia != null)
                {
                    caixaPostal = nokia.CaixaPostal;
                }
            } else if (modelo == "iPhone")
            {
                IPhone? iPhone = _iPhoneLIST.FirstOrDefault(p => p.Number == number);
                if (iPhone != null)
                {
                    caixaPostal = iPhone.CaixaPostal;
                }
            }

            return caixaPostal;
        }
        public void Print_Lista()
        {
            if (_nokiaLIST.Count != 0)
            {
                Console.WriteLine("\t--Lista Nokia...");
                foreach (Nokia nokia in _nokiaLIST)
                {
                    Console.WriteLine(
                        $"Number:  {nokia.Number}\n"+
                        $"Modelo:  {nokia.Modelo}\n"+
                        $"IMEI:    {nokia.IMEI}\n"+
                        $"Mémoria: {nokia.Memoria}\n"+
                        "............................."
                    );
                }
                Console.WriteLine("-----------------------------");
            } else
            {
                Console.WriteLine("--- Não tem Nokias registrados ---");
            }

            if (_iPhoneLIST.Count != 0)
            {
                Console.WriteLine("\t--Lista iPhone...");
                foreach (IPhone iPhone in _iPhoneLIST)
                {
                    Console.WriteLine(
                        $"Number:  {iPhone.Number}\n"+
                        $"Modelo:  {iPhone.Modelo}\n"+
                        $"IMEI:    {iPhone.IMEI}\n"+
                        $"Mémoria: {iPhone.Memoria}\n"+
                        "............................."
                    );
                }
                Console.WriteLine("-----------------------------");
            } else
            {
                Console.WriteLine("--- Não tem iPhones registrados ---");
            }
        }
        public void Desserializacao()
        {
            _nokiaLIST = Json.Desserializacao_Nokia();
            _iPhoneLIST = Json.Desserializacao_iPhone();
        }
        public void Serializacao()
        {
            string register_nokia = JsonConvert.SerializeObject(_nokiaLIST, Formatting.Indented);
            Json.Serializacao(register_nokia, "Nokia");

            string register_iPhone = JsonConvert.SerializeObject(_iPhoneLIST, Formatting.Indented);
            Json.Serializacao(register_iPhone, "iPhone");
        }
    }
}