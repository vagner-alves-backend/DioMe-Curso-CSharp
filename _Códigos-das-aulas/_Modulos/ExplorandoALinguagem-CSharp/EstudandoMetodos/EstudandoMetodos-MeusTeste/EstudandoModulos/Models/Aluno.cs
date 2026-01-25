using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoModulos.Models
{
    public class Aluno
    {
        private readonly string? _alunoName;
        private readonly string? _alunoSenha;
        private readonly string? _alunoCurso;

        public Aluno() : this("NaN", "NaN", "NaN"){}
        public Aluno(string? name, string? senha) : this(name, senha, "NaN"){}
        public Aluno(string? name, string? senha, string? curso) 
        {
            this._alunoName = name;
            this._alunoSenha = senha;
            this._alunoCurso = curso;
        }

        public string? GetAlunoName() => _alunoName;
        public string? GetAlunoSenha() => _alunoSenha;
        public string? GetAlunoCurso() => _alunoCurso;
    }
}
