using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public class DataBase
    {
        private List<Nokia> _nokiaLIST = Json.Desserializacao_Nokia();
        private List<IPhone> _iPhoneLIST = Json.Desserializacao_iPhone();
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