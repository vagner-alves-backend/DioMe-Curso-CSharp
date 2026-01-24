using operadores.Models;

string? desejaContinuar = "null";
bool continuar = true;
int rodarProgamaNovamente = 0;

int erroNaConvercao = 0;
string? primeiroNumero = "null";
string? segundoNumero = "null";
int primeiroNum = 0;
int segundoNum = 0;
bool valorValido = true;

do
{

    do
    {
        Console.WriteLine("Informe um número: ");
        primeiroNumero = Console.ReadLine();
        valorValido = int.TryParse(primeiroNumero, out erroNaConvercao);
        if (valorValido == false)
        {
            Console.WriteLine($"\t[Erro]: O valor '{primeiroNumero}' é invalido, Informe um valor valido...\n");
        }
    } while (!valorValido);
    primeiroNum = Convert.ToInt32(primeiroNumero);


    do
    {
        Console.WriteLine("Informe mais um número: ");
        segundoNumero = Console.ReadLine();
        valorValido = int.TryParse(segundoNumero, out erroNaConvercao);
        if (valorValido == false)
        {
            Console.WriteLine($"\t[Erro]: O valor '{segundoNumero}' é invalido, Informe um valor valido...\n");
        }
    } while (!valorValido);
    segundoNum = Convert.ToInt32(segundoNumero);

    Calculadora calculos = new()
    {
        Valor1 = primeiroNum,
        Valor2 = segundoNum
    };   

    calculos.Calcular();

    do
    {
        Console.WriteLine("\t---Menu---\n"+
                        "\t[1] Sim\n"+
                        "\t[2] Nao\n");
        desejaContinuar = Console.ReadLine();
        continuar = int.TryParse(desejaContinuar, out erroNaConvercao);   
        if (continuar == false)
        {
            Console.WriteLine("\t[Erro]: Valor informado invalido, favor informar um valor valido...\n");
        } 
    } while (!continuar);
    rodarProgamaNovamente = Convert.ToInt32(desejaContinuar);

} while (rodarProgamaNovamente != 2);

string? desejaVerQualTabuada = "null";
bool maisUmaTabuada = true;
int tabuada = 0;
int valorInvalido = 0;
do
{
    do
    {
        Console.WriteLine("---Qual tabuada..: ");
        desejaVerQualTabuada = Console.ReadLine();
        maisUmaTabuada = int.TryParse(desejaVerQualTabuada, out valorInvalido);
        if (maisUmaTabuada == false)
        {
            Console.WriteLine($"\t[Erro]: O valor [{desejaVerQualTabuada}] é inrregular, informe um novo valor...");
        }
    } while (!maisUmaTabuada);
    tabuada = Convert.ToInt32(desejaVerQualTabuada);

    for (int numero = 1; numero <= 10; numero++)
    {
        Console.WriteLine($"\t{numero} x {tabuada} = {numero * tabuada}\n");
    }

    do
    {
        Console.WriteLine("---Deseja ver a tabuada de outro número?\n[1] Sim \n[2] Não ");
        desejaVerQualTabuada = Console.ReadLine();
        maisUmaTabuada = int.TryParse(desejaVerQualTabuada, out valorInvalido);

        if (maisUmaTabuada == false)
        {
            Console.WriteLine($"[ERRO]: Valor inrregular, informe um valor valido..");
        } else
        {
            tabuada = Convert.ToInt32(desejaVerQualTabuada);
            if (tabuada < 1 || tabuada > 2)
            {
                Console.WriteLine("\tParametro não encontrado, informe um parametro valido...");
            }
        }
    } while (!maisUmaTabuada);
} while (tabuada != 2);

