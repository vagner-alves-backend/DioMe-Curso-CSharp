using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacioamento_Main_VersãoFinal.Models
{
    public class ValidNumber
    {
        public string? NumberText { get; set; }
        public void Valid()
        {
            int number = 0;
            bool numberValid = true;
            do
            {
                numberValid = int.TryParse(NumberText, out number);
                if (numberValid == false)
                {
                    Console.Write(
                        $"O valor [{NumberText}] é invalido.\n" +
                        "Informe um número valido..: "
                    );
                    NumberText = Console.ReadLine();
                }
            } while (!numberValid);
        }
    }
}