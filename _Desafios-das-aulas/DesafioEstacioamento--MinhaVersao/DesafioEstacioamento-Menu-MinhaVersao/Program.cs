using DesafioEstacioamento_ModelsClass_MinhaVersao.Models;

ToAddVehicle add = new()
{
    Name = "Null",
    ParkingSpaces = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
};


bool finishTask = false;
bool optionValid = false;

string? optionSelected = "Null";

int optionChosen = 0;
int returnOption = 0;
int parkingFree = 0;
int vacancy = 0;
do
{
    do
    {
        //  Opções do menu
        Console.WriteLine(
            "---\tSettings\n"+
            "1- To add\n"+
            "2- Remove\n"+
            "3- Search\n"+
            "4- List");
        optionSelected = Console.ReadLine();

        // Tratando dados recebidos ---optionSelected
        optionValid = int.TryParse(optionSelected, out returnOption);
        if (optionValid == false)
        {
            Console.WriteLine("\t[Erro]: Informe um valor valido...");
        } else
        {
            optionChosen = Convert.ToInt32(optionSelected);
            if (optionChosen < 1 || optionChosen > 4)
            {
                Console.WriteLine("\tOpção invalida, favor informe uma opção presente no menu.");
                optionValid = false;
            }
        }
    } while (!optionValid);

    switch (optionChosen)
    {
        case 1: //  To add ---Adicionar.
            Console.WriteLine("Name: ");
            add.Name = Console.ReadLine();

            parkingFree = add.FreeVacancy();
            if (parkingFree != 404)
            {
                vacancy++;
                Console.WriteLine($"Sua vaga é a --{vacancy}");
                add.ParkingSpaces[parkingFree] = vacancy;
            }
            break;
    }
} while (finishTask);
