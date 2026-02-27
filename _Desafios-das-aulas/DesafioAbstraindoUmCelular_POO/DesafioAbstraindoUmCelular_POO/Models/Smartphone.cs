using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAbstraindoUmCelular_POO.Models
{
    public abstract class Smartphone
    {
        private string? _numero;
        public string? Numero
        {
            get => this._numero;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception ($"Campo obrigatorio não preenchido [Number]. [{value}]");
                this._numero = value;
            }
        }
        private string? _modelo;
        public string? Modelo
        {
            get => this._modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception ("Campo obrigatorio não preenchido [Modelo].");
                this._modelo = value;
            }
        }
        private string? _imei;
        public string? IMEI
        {
            get => this._imei;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new Exception ("Campo obrigatorio não preenchido [IMEI].");
                this._imei = value;
            }
        }
        private int _memoria;
        public int Memoria
        {
            get => this._memoria;
            set
            {
                if (value <= 16 || value > 1000) throw new Exception ("Memoria inrregula.");
                this._memoria = value;
            }
        }

        public Smartphone (string? numero, string? modelo, string? imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }

        public string? GetNumero () => this._numero;
        public string? GetModelo () => this._modelo;
        public string? GetIMEI () => this._imei;
        public int GetMemoria () => this._memoria;

        public (string? modelo, string? number) Ligar ()
        {
            Console.Clear();
            Console.Write(
                "---Deseja ligar para...\n"+
                "\t--Modelo..\n"+
                "1° Nokia\n"+
                "2° iPhone\n"+
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

            return (modelo, number);
        }
        public abstract void ReceberLigacao (string? modelo, string? number);
        public abstract void InstalarAplicativo (string? nameApp);
    }
}