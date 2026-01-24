using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Cet_e_Set_Main.Models
{
    public static class GetESet
    {
        private static string? _number;
        private static string? Number
        {
            get => _number;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value Null.");
                }

                if (!int.TryParse(value, out _))
                {
                    throw new ArgumentException("Not Number.");
                }

                _number = value;
            }
        }

        public static int IsNumber()
        {
            bool sucesso = false;
            int number = 0;
            while (!sucesso)
            {
                Console.Write("Number..: ");
                try
                {
                    Number = Console.ReadLine();
                    number = Convert.ToInt32(_number);
                    sucesso = true;
                } catch (ArgumentException erro)
                {
                    Console.WriteLine($"[Erro]: {erro.Message}");
                }
            }
            return number;
        }
    
        // public void IsNumber()
        // {
        //      Console.Write("Informe um number..: ");
        //      try
        //      {
        //          Number = Console.ReadLine();
        //          Console.WriteLine($"\t-Number.: {Convert.ToInt32(_number)}");
        //      } catch (ArgumentException ex)
        //      {
        //          Console.WriteLine(ex.Message);
        //          IsNumber();
        //      }

        //     bool sucesso = false;
        //     while (!sucesso)
        //     {
        //         Console.Write("Informe um number..: ");
        //         try
        //         {
        //             Number = Console.ReadLine();
        //             Console.WriteLine($"O number informado foi : {Convert.ToInt32(Number)}.");
        //             sucesso = true;
        //         } catch (ArgumentException ex)
        //         {
        //             Console.WriteLine($"[Erro]: {ex.Message}.");
        //             Console.WriteLine("\t-Tente novamente.");
        //         }
        //     }
        // }

    }
}
