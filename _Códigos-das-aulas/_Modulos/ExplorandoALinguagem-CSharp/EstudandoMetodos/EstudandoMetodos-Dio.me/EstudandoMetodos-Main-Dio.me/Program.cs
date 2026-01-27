using EstudandoMetodos_Main_Dio.me.Models;

Curso matriculas = new();
bool continuar = true;

string? opcaoMenu = "";
Console.Clear();
do
{
    Console.Write(
        "--\tMenu\n"+
        "[1] Adiconar\n"+
        "[2] Lista\n"+
        "[3] Remover\n"+
        "[4] Finalizar..: "
    );
    opcaoMenu = Console.ReadLine();
    Console.Clear();
    switch (opcaoMenu)
    {
        case "1":
            Console.Write("Name..: ");
            matriculas.SetAlunoName(Console.ReadLine());
            Console.Write("Curso.: ");
            matriculas.SetAlunoCurso(Console.ReadLine());
            matriculas.Aluno.Add(new(name: matriculas.GetAlunoName(), curso: matriculas.GetAlunoCurso()));
            break;
        case "2":
            matriculas.ListaAlunos();
            break;
        case "3":
            if (matriculas.QuantidadeDeMatriculas() < 1)
            {
                Console.WriteLine("\t-Não a registros.");
            } else
            {
                matriculas.RemoverAluno(matriculas.Aluno[matriculas.QuantidadeDeMatriculas() -1]);
            }
            break;
        case "4":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção Invalida, por favor informe uma opção valida.");
            break;
    }
} while (continuar);
