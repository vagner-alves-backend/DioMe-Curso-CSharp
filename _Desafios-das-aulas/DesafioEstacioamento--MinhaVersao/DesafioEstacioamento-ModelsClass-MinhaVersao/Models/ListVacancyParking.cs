using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacioamento_ModelsClass_MinhaVersao.Models
{
    public class ListVacancyParking
    {
        public string?[] Name = [];
        public string?[] Vehicle = [];
        public int[] Vacancy = [10];

        public void PrintDataParking()
        {
            for (int index = 0; index < Name.Length; index++)
            {
                if (Name[index] != "Null")
                {
                    Console.WriteLine(
                        $"-Vaga {Vacancy[index]}\n"+
                        $"\t{Name[index]}\n"+
                        $"\t{Vehicle[index]}\n"+
                        "------------------------------"
                    );
                }
            }
        }
    }
}
