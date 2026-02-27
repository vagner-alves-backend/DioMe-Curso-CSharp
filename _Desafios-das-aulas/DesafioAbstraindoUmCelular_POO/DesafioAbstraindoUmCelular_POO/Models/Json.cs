using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public class Json
    {
        private readonly string _pathNokia = "C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Desafios-das-aulas\\DesafioAbstraindoUmCelular_POO\\DesafioAbstraindoUmCelular_POO\\DataBase\\Json\\nokia.json";
        private readonly string _pathiPhone = "C:\\Users\\Vágner Alves\\OneDrive\\Documentos\\DioMe-Curso-CSharp\\_Desafios-das-aulas\\DesafioAbstraindoUmCelular_POO\\DesafioAbstraindoUmCelular_POO\\DataBase\\Json\\iPhone.json";
        private List<Nokia> _nokia = [];
        private List<IPhone> _iPhone = [];

        public void AdicionarSmartphone (string? number, string? modelo, string? imei, int memoria)
        {
            switch (modelo)
            {
                case "Nokia": _nokia.Add(new(number, modelo, imei, memoria)); break;
                case "iPhone": _iPhone.Add(new(number, modelo, imei, memoria)); break;
                default:
                    Console.WriteLine("Não foi possível adicionar o smartphone.");
                    break;
            }
        }
        public bool AcessarSmartphone (string? modelo, string? number)
        {
            bool acessou = modelo switch
            {
                "Nokia" => this._nokia.Any(p => p.GetNumero() == number),
                "iPhone" => this._iPhone.Any(p => p.GetNumero() == number),
                _ => false
            };

            return acessou;
        }
        public void Ligar (string? modelo, string? number)
        {
            (string? modeloContato, string? numberContato) contato = ("NaN", "NaN");
            bool ligou = true;
            switch (modelo)
            {
                case "Nokia":
                    Nokia? nokia = AcessarSmartphoneNokia (number);
                    if (nokia != null)
                    {
                        contato = nokia.Ligar();
                    }
                    break;
                case "iPhone":
                    IPhone? iPhone = AcessarSmartphoneiPhone (number);
                    if (iPhone != null)
                    {
                        contato = iPhone.Ligar();
                    } 
                    break;
                default:
                    Console.WriteLine("-- Não foi possível completar  ligação... --");
                    ligou = false;
                    break;
            }

            switch (contato.modeloContato)
            {
                case "Nokia":
                    Nokia? nokia = AcessarSmartphoneNokia (contato.numberContato);
                    nokia?.CaixaPostal.Add(new(modelo, number));
                    break;
                case "iPhone":
                    IPhone? iPhone = AcessarSmartphoneiPhone (contato.numberContato);
                    iPhone?.CaixaPostal.Add(new(modelo, number));
                    break;
                default:
                    Console.WriteLine("-- Não foi possível adicionar chamada perdiada a caixa postal. --");
                    ligou = false;
                    break;
            }

            if (ligou)
            {
                Serializacao();
                Desserializacao();
            }            
        }
        public void ChequeCaixaPostal (string? modelo, string? number) 
        {
            switch (modelo)
            {
                case "Nokia": 
                    Nokia? nokia = AcessarSmartphoneNokia(number);
                    nokia?.PrintCaixaPostal();
                    break;
                case "iPhone": 
                    IPhone? iPhone = AcessarSmartphoneiPhone(number);
                    iPhone?.PrintCaixaPostal();
                    break;
                default:
                    Console.WriteLine("-- Não foi possível acessar a caixa postal... --");
                    break;
            }
        }
        public void InstalarAplicativo (string? modelo, string? number, string? nameApp)
        {
            switch (modelo)
            {
                case "Nokia":
                    Nokia? nokia = AcessarSmartphoneNokia (number);
                    nokia?.InstalarAplicativo(nameApp);
                    break;
                case "iPhone":
                    IPhone? iPhone = AcessarSmartphoneiPhone (number);
                    iPhone?.InstalarAplicativo(nameApp);
                    break;
                default:
                    Console.WriteLine("-- Não foi possível instalar o aplicativo... --");
                    break;
            }
        }
        public void ChequeAplicativosInstalados (string? modelo, string? number) 
        {
            switch (modelo)
            {
                case "Nokia": 
                    Nokia? nokia = AcessarSmartphoneNokia(number);
                    nokia?.PrintAplicativos();
                    break;
                case "iPhone": 
                    IPhone? iPhone = AcessarSmartphoneiPhone(number);
                    iPhone?.PrintAplicativos();
                    break;
                default:
                    Console.WriteLine("-- Não foi possível acessar os apps... --");
                    break;
            }
        }

        private Nokia? AcessarSmartphoneNokia (string? number) => this._nokia.FirstOrDefault(p => p.GetNumero() == number);
        private IPhone? AcessarSmartphoneiPhone (string? number) => this._iPhone.FirstOrDefault(p => p.GetNumero() == number);

        public void Desserializacao ()
        {
            string? registrosNokia = File.ReadAllText(_pathNokia);
            _nokia = JsonConvert.DeserializeObject<List<Nokia>>(registrosNokia) ?? [];

            string? registrosiPhone = File.ReadAllText(_pathiPhone);
            _iPhone = JsonConvert.DeserializeObject<List<IPhone>>(registrosNokia) ?? [];
        }
        public void Serializacao ()
        {
            string? registrosNokia = JsonConvert.SerializeObject(_nokia, Formatting.Indented);
            File.WriteAllText(_pathNokia, registrosNokia);
        
            string? registrosiPhone = JsonConvert.SerializeObject(_iPhone, Formatting.Indented);
            File.WriteAllText(_pathiPhone, registrosiPhone);
        }
    }
}