using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace EstudandoModulos.Models
{
    public class Login : Faculdade
    {
        private bool _loginValido = false;
        private string? _nivelDeAcesso;
        public Login() : this("NaN"){}
        public Login(string? acesso)
        {
            _nivelDeAcesso = acesso;
        }

        public void SetAcesso(string? acesso) => _nivelDeAcesso = acesso;
        public void LoginUser()
        {
            Console.WriteLine(
                "\t-Login\n"+
                "--------------------"
            );
            switch (_nivelDeAcesso)
            {
                case "admin":
                    LoginAdmin();
                    break;
                case "professor":
                    Console.Write("-Nome...: \n");
                    Console.Write("-Curso..: \n");
                    Console.Write("-Senha..: \n");
                    break;
                case "aluno":
                    LoginAluno();
                    break;
                case "fim":
                    Console.Clear();
                    Console.WriteLine("\t\tFim de execulção..");
                    _loginValido = false;
                    break;
                default:
                    Console.WriteLine("Nível de acesso não informado.");
                    break;
            }

        }

        private void LoginAdmin()
        {
            Console.Clear();
            Console.WriteLine(
                "-   Login Admin\n"+
                "--------------------"
            );
            Console.Write("-Name..: ");
            SetName(Console.ReadLine());
            Console.Write("-Senha.: ");
            SetSenha(Console.ReadLine());

            _loginValido = LoginExiste("admin");
        }
        private void LoginAluno()
        {
            Console.Clear();
            Console.WriteLine(
                "-   Login Aluno\n"+
                "--------------------"
            );
            Console.Write("-Nome...: ");
            SetName(Console.ReadLine());
            Console.Write("-Senha..: ");
            SetSenha(Console.ReadLine());

            _loginValido = LoginExiste("aluno");
        }
        public bool VerifiqueLogin() => _loginValido;
    }
}
