using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoModulos.Models
{
    public class Admin : Aluno
    {
        protected List<Aluno> _alunos = [new("Vágner", "123")];
        private readonly string? _name;
        private readonly string? _senha;

        public Admin() : this("NaN", "NaN"){}
        public Admin(string? name, string? senha)
        {
            this._name = name;
            this._senha = senha;
        }

        public string? GetAdminName() => _name;
        public string? GetAdminSenha() => _senha;

        public void PrivilegiosDeAdm()
        {
            bool continuar = true;
            string? finalizar;
            while (continuar)
            {
                switch (MenuAdimin())
                {
                    case "1":
                        AdicionarAluno();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.Clear();
                        continuar = false;
                        break;

                    default:
                        Console.Write(
                            "\t-Opção invalida.\n"+
                            "Deseja finalizar o programa?\n"+
                            "[1] Sim\n"+
                            "[2] Não..: "
                        );
                        finalizar = Console.ReadLine();
                        if (finalizar != "2")
                        {
                            continuar = false;
                        }
                        break;
                }
            }
            
        }
        private static string? MenuAdimin()
        {
            Console.Clear();
            Console.Write(
                "\t-Admin\n"+
                "--------------------\n"+
                "1- Adicionar Aluno.\n"+
                "2- Adicionar Professor.\n"+
                "3- Remover Aluno.\n"+
                "4- Remover Professor.\n"+
                "5- Deslogar..: "
            );
            return Console.ReadLine();
        }

        private void AdicionarAluno()
        {
            string? name = "";
            string? senha = "";
            //string? curso = "";

            Console.Clear();
            Console.WriteLine(
                "- Adicionar Aluno\n"+
                "--------------------"
            );
            Console.Write("-Name..: ");
            name = Console.ReadLine();
            Console.Write("-Senha.: ");
            senha = Console.ReadLine();

            _alunos.Add(new(name, senha));
        }
    }
}
