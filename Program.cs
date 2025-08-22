using Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.Title = "DOTNET PARKING SYSTEM";
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("===================================");
Console.WriteLine("| WELCOME TO DOTNET PARKING SYSTEM |");
Console.WriteLine("===================================");
Console.ResetColor();
Console.WriteLine("Please enter the initial price for parking:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now, please enter the hourly rate for parking:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());


Parking parking = new Parking(initialPrice, pricePerHour);

string opcao = string.Empty;
bool displayMenu = true;

while (displayMenu)
{
    Console.Clear();
    Console.WriteLine("===================================");
    Console.WriteLine("       DOTNET PARKING SYSTEM");
    Console.WriteLine("===================================");
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("1 - Add vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Exit");

    switch (Console.ReadLine())
    {
        case "1":
            parking.AddVehicle();
            break;

        case "2":
            parking.RemoveVehicle();
            break;

        case "3":
            parking.ListVehicles();
            break;

        case "4":
            displayMenu = false;
            break;

        default:
            Console.WriteLine("Invalid option, please try again.");
            break;
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadLine();
}

Console.WriteLine("Thank you for using the DOTNET Parking System!");
