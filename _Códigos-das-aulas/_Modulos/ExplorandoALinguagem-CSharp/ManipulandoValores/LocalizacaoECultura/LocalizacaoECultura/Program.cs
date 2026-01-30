//Normalmente a localização é definida de forma altomatica, usando as configurações do sistema, mas 
//para forçar essa mudança podemos usar o comando.:
using System.Data;
using System.Globalization;
decimal valorMonetario = 1245.45M;
Console.WriteLine($"Por padrão do meu sistema..: {valorMonetario, 10:C}");
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"Sistema en-US..: {valorMonetario, 10:C}");

//Alterando a localização da cultura.:
Console.WriteLine($"Sistema es-ES..: {valorMonetario.ToString("C", new CultureInfo("pt-BR"))}");

//Em formato de porcetagem..:
double porcentagem = 0.01;
Console.WriteLine($"Em formato de porcentagem..: {porcentagem.ToString("P")}");



//Calculo de porcentagem..: 
Console.Clear();

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
bool _continue = true;
double valorBruto = 0;
string? end = "";
do
{
    Console.Write("Valor bruto..: ");
    valorBruto = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Quantos porcentos deseja calcular\nsobre {valorBruto:C}? ");
    porcentagem = Convert.ToDouble(Console.ReadLine());
    porcentagem /= 100;
    Console.WriteLine(
        "--------------------------------------\n"+
        $"{porcentagem*100}% de {valorBruto:C} sera.: {valorBruto*porcentagem:C}\n"+
        "--------------------------------------\n"
    );
    end = Console.ReadLine();
    _continue = end != "f";
    Console.Clear();
} while (_continue);

//Formato de string personalizado..:
long cpf = 12343206798;
Console.WriteLine($"Formato de CPF {cpf.ToString("### ### ### ##")}");
