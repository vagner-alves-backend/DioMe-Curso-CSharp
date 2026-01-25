using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace EstudandoModulos.Models
{
    public class Faculdade : Admin
    {
        private readonly List<Admin> _admins = [new("Lucas", "123"), new("Matheus", "123"), new("Laura", "123")];
        private string? _NomeAtual;

        private string? _name = "";
        private string? _curso = "";
        private string? _senha = "";

        public Faculdade() : this("NaN", "NaN", "NaN") {}
        public Faculdade(string? name, string? senha) : this(name, "NaN", senha) {}
        public Faculdade(string? name, string? curso, string? senha)
        {
            _name = name;
            _curso = curso;
            _senha = senha;
        }

        public void SetName(string? name) => _name = name;
        public void SetSenha(string? senha) => _senha = senha;
        public void SetCurso(string? curso) => _curso = curso;

        private bool CheckLogin(string? nivel)
        {
            bool loginValido = false;
            switch (nivel)
            {
                case "admin":
                    for (int index = 0; index < _admins.Count; index++)
                    {
                        if (_admins[index].GetAdminName() == _name && _admins[index].GetAdminSenha() == _senha)
                        {
                            loginValido = true;
                            _NomeAtual = _admins[index].GetAdminName();
                        }
                    }
                    break;
                case "professor":
                    break;
                case "aluno":
                    for (int index = 0; index < _alunos.Count; index++)
                    {
                        if (_alunos[index].GetAlunoName() == _name && _alunos[index].GetAlunoSenha() == _senha)
                        {
                            loginValido = true;
                            _NomeAtual = _alunos[index].GetAlunoName();
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Login invalido.");
                    loginValido = false;
                    break;
            }
            
            return loginValido;
        }

        public string? GetNameAtual() => _NomeAtual;
        public bool LoginExiste(string? nivel) => CheckLogin(nivel);
        public void PrivilegiosDeAluno()
        {
            Console.WriteLine(
                "--------Perfil\n"+
                $"Name..\t{_NomeAtual}\n"+
                "Curso..\tCiências da Computação\n"+
                "-----------------------------------------------"
            );
            Console.ReadLine();
        }
    }
}
