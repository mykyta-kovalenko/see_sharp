using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[D]elete a TODO");
Console.WriteLine("[Q]uit");

string userInput = Console.ReadLine()?.ToUpper() ?? "";

switch (userInput)
{
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "D":
        PrintSelectedOption("Delete a TODO");
        break;
    case "Q":
        PrintSelectedOption("Quit");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}

Console.Read();

static void PrintSelectedOption(string option)
{
    Console.WriteLine($"Selected option: {option}");
}