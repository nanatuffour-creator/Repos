using System.Globalization;
using System.Text.RegularExpressions;

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
        Time();
        goto RETURN;
    }
    else if (ss == 2)
    {
        Calculator();
        goto RETURN;
    }
    else if (ss == 3)
    {
        Age();
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


//Time Counter.
 void Time()
{
    Console.WriteLine("Time Counter");
    Console.Write("Enter hours : ");
    var hour = Console.ReadLine();
    var parsed = int.TryParse(hour, out int hours);
    Console.Write("Enter minutes : ");
    var minute = Console.ReadLine();
    parsed = int.TryParse(minute, out int minutes);
    Console.Write("Enter seconds : ");
    var second = Console.ReadLine();
    parsed = int.TryParse(second, out int seconds);

    TimeSpan time = new TimeSpan(hours, minutes, seconds);

    while (time.TotalSeconds >= 0)
    {
        Console.Write($"\rTime left : {time:hh\\:mm\\:ss}");
        time = time.Subtract(TimeSpan.FromSeconds(1));
        Task.Delay(1000).Wait();
    }
    Console.WriteLine("\nTime up");
    //return time;
}

//Calculator
void Calculator()
{
    while (true)
{
    Console.WriteLine("\nCalculator");
REPEAT:
    Console.WriteLine("1.Addition");
    Console.WriteLine("2.Division");
    Console.WriteLine("3.Multiplication");
    Console.WriteLine("4.Subtraction");
    Console.Write("Please choose your option : ");
    var select = Console.ReadLine();
    var parses = int.TryParse(select, out int selected);

    Console.Write("Please enter your first number : ");
    var first = Console.ReadLine();
    parses = decimal.TryParse(first, out decimal firstNum);

    Console.Write("Please enter your second number : ");
    var secondNumber = Console.ReadLine();
    parses = decimal.TryParse(secondNumber, out decimal secondNum);

    decimal results;

    if (selected == 1)
    {
        results = firstNum + secondNum;
        Console.WriteLine($"Your Answer is {results}");
        goto BACK;
    }
    else if (selected == 2)
    {
        if (secondNum == 0)
        {
            Console.WriteLine($"Your Answer is undefined");
            goto BACK;
        }

        results = firstNum / secondNum;
        Console.WriteLine($"Your Answer is {results}");
        goto BACK;

    }
    else if (selected == 3)
    {
        results = firstNum * secondNum;
        Console.WriteLine($"Your Answer is {results}");
        goto BACK;
    }
    else if (selected == 4)
    {
        results = firstNum - secondNum;
        Console.WriteLine($"Your Answer is {results}");
        goto BACK;
    }
BACK:
    Console.Write("Do you want to continue (y/n): ");
    var check = Console.ReadKey();
    if (check.Key == ConsoleKey.Y) { Console.WriteLine(); goto REPEAT; }
    else if (check.Key == ConsoleKey.N) { Console.WriteLine(); break; }
    else { Console.WriteLine(); Console.WriteLine("INVALID INPUT"); goto BACK; }
    
}
}

//Age Calculator


static void Age()
{
    while(true)
    {
        Console.Write("Enter date of birth (eg:yyyy-MM-dd): ");
        string? input = Console.ReadLine();
        //DateTime dob = DateTime.Parse(Console.ReadLine());
        if (input == null || input.Trim() == "")
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            DateTime dob = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);

            DateTime today = DateTime.Today;
            TimeSpan newDate = today - dob;

            decimal year = newDate.Days / 365;
            decimal month = newDate.Days % 365;
            decimal months = month / 31;
            decimal day = months % 31;


            Console.WriteLine($"You are {Math.Round(year)} years, {Math.Round(months)} months, and {Math.Round(day)} days old.");
        }
    
        BACK:
            Console.Write("Do you want to continue (y/n): ");
            var checker = Console.ReadKey();
            if (checker.Key == ConsoleKey.Y) { Console.WriteLine(); continue; }
            else if (checker.Key == ConsoleKey.N) { Console.WriteLine(); break; }
            else { Console.WriteLine(); Console.WriteLine("INVALID INPUT"); goto BACK; }
    }


}