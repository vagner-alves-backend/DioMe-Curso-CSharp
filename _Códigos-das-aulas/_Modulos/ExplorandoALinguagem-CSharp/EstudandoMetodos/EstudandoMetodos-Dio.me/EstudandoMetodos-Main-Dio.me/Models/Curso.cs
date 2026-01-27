using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoMetodos_Main_Dio.me.Models
{
    public class Curso : Pessoa
    {
        //private readonly string? _curso;
        public List<Pessoa> Aluno = [];
        public void AdicionarAluno(Pessoa aluno) => Aluno.Add(aluno);
        public int QuantidadeDeMatriculas() => Aluno.Count;
        public void RemoverAluno(Pessoa aluno)
        {
            Console.WriteLine("\tRemovido...");
            Console.WriteLine(
                "--Perfil...\n"+
                $"- {aluno.GetAlunoName()}\n"+
                $"- {aluno.GetAlunoCurso()}\n"+
                "..............................."
            );
            Aluno.Remove(aluno);
        }

        public void ListaAlunos()
        {
            Console.WriteLine("\tLista de Alunos");
            foreach (Pessoa aluno in Aluno)
            {
                Console.WriteLine(
                    "--Perfil...\n"+
                    $"- {aluno.GetAlunoName()}\n"+
                    $"- {aluno.GetAlunoCurso()}\n"+
                    "..............................."
                );
            }
        }
    }
}
