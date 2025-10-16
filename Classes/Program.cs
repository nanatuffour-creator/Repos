// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

while (true)
{
MAIN :
Console.WriteLine("1.Time Counter.");
Console.WriteLine("2.Calculator.");
Console.WriteLine("3.Age Calculator.");
Console.Write("Please choose your option : ");
var s = Console.ReadLine();
var par = int.TryParse(s, out int ss);

    if (ss == 1)
    {
        Timer time = new Timer();
        time.Mains();
        goto RETURN;
    }
    else if (ss == 2)
    {
        Calculator calculate = new Calculator();
        calculate.Mains();
        goto RETURN;
    }
    else if (ss == 3)
    {
        Age newAge = new Age();
        newAge.Receive();
        goto RETURN;
    }

RETURN:
    Console.WriteLine();
    Console.Write("Do you want to continue to the main program(y/n): ");
    var checks = Console.ReadKey();
    if (checks.Key == ConsoleKey.Y) { Console.WriteLine(); goto MAIN; }
    else if (checks.Key == ConsoleKey.N) { Console.WriteLine(); break; }
    else { Console.WriteLine(); Console.WriteLine("INVALID INPUT"); goto RETURN; }
}






