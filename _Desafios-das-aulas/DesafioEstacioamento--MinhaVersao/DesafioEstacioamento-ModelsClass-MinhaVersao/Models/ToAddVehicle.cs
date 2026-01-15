using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacioamento_ModelsClass_MinhaVersao.Models
{
    public class ToAddVehicle
    {
        public string? Name {get; set;}
        public int[] ParkingSpaces = [10];

        public int FreeVacancy()
        {
            int position = 404;
            Console.WriteLine($"Olá {Name}, iremos verificar se a uma vaga livre para você.");
            for (int index = 0; index < ParkingSpaces.Length; index++)
            {
                if (ParkingSpaces[index] == 0)
                {
                    Console.WriteLine("Muito bem, temos uma vaga livre para você.");
                    position = index;
                    break;
                } else if (index == 9)
                {
                    Console.WriteLine("Infelizmente não temos vagas livres no momento.");
                }
            }

            return position;
        }
    }
}
