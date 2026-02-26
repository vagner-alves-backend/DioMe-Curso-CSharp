using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public abstract class Smartphone
    {
        private string? _number;
        private string? _modelo;
        private string? _imei;
        private int _memoria;
        public string? Number
        {
            get => this._number;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("Favor informe o número do usuario.");
                if (!int.TryParse(value, out int number)) throw new Exception("Favor informe um valor numerico.");
                if (number < 10000000 || number > 99999999) throw new Exception("O número informado é invalido.");
                this._number = value;
            }
        }
        public string? Modelo
        {
            get => this._modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception("Favor informe o Modelo do smartphone.");
                _modelo = value;
            }
        }
        public string? IMEI
        {
            get => this._imei;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception ("Favor informe o IMEI do smartphone.");
                _imei = value;
            }
        }
        public int Memoria
        {
            get => this._memoria;
            set
            {
                if (value <= 16) throw new Exception ("Mémoria inregular, favor informe a mémoria do smartphone.");
                _memoria = value;
            }
        }
        public Smartphone(string? number, string? modelo, string? imei, int memoria) 
        {
            this.Number = number;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }
        public void Ligar()
        {
            Console.Clear();
            Console.Write("Olá usuaro, informe o número da pessoa para qual você deseja ligar: ");
            string? number = Console.ReadLine();
            Console.Write($"Você ligou para: {number}");
        }
        public void ReceberLigacao() => Console.WriteLine($"Você recebeu uma ligação de {_number}");
        public abstract void InstalarAplicativo(string nomeApp);
    }
}