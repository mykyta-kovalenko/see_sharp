Console.WriteLine("Hello!\nInput the first number:");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("Input the second number:");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userChoice = Console.ReadLine()?.ToUpper()!;

switch (userChoice)
{
    case "A":
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        break;
    case "S":
        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        break;
    case "M":
        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}

Console.WriteLine("Press any key to close");
Console.ReadKey();