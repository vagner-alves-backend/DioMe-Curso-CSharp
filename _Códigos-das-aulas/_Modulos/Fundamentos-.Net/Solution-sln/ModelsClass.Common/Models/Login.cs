using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsClass.Common.Models
{
    public class Login
    {
        public string? Name { get; set;}
        public int Senha { get; set;}
        public int User { get; set;}

        public void LoginUser(string? nomeInformado, int senhaInformada)
        {
            if (nomeInformado == Name && senhaInformada == Senha)
            {
                if (User == 1) // Login de adiministrador...
                {
                    Console.WriteLine($"Login bem sucedido, seja bem vindo adm {Name} ;)");
                } else if (User == 2)
                {
                    Console.WriteLine($"Login bem sucedido, seja bem vindo {Name}");
                }
            } else
            {
                Console.WriteLine("Acesso negado, login não existe");
            }
        }
    }
}