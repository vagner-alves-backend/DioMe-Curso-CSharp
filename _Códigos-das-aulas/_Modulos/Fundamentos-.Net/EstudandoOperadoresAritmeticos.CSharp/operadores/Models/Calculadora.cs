using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace operadores.Models
{
    public class Calculadora
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set;}

        public void Calcular()
        {
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine($"{Valor1} + {Valor2} = {Valor1 + Valor2} \n"+
                              $"{Valor1} - {Valor2} = {Valor1 - Valor2} \n"+
                              $"{Valor1} x {Valor2} = {Valor1 * Valor2} \n"+
                              $"{Valor1} : {Valor2} = {Math.Round((Valor1 / Valor2), 2)}");
            Console.WriteLine("+------------------------------+\n");
        }
    }
}