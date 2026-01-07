using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiposDeDados.Modelos
{
    public class Dados
    {
        public String? Nome {get; set;}
        public int? Inteiro {get; set;}
        public float? Floate {get; set;}
        public double? Double {get; set;}
        public byte? Byte {get; set;}
        public decimal? Decimal {get; set;}
        public bool? Boleano {get; set;}

        public void EscrevaDados()
        {
            Console.WriteLine(
                $"String.:\t {Nome}\n"+
                $"Inteiro:\t {Inteiro}\n"+
                $"Float..:\t {Floate}\n"+
                $"Double.:\t {Double}\n"+
                $"Byte...:\t {Byte}\n"+
                $"Decimal:\t {Decimal}\n"+
                $"Boleano:\t {Boleano}\n");
        }
    }
}
