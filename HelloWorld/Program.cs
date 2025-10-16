// //Time Counter.
// Console.WriteLine("Time Counter");
// Console.Write("Enter hours : ");
// var hour = Console.ReadLine();
// var parsed = int.TryParse(hour, out int hours);
// Console.Write("Enter minutes : ");
// var minute = Console.ReadLine();
// parsed = int.TryParse(minute, out int minutes);
// Console.Write("Enter seconds : ");
// var second = Console.ReadLine();
// parsed = int.TryParse(second, out int seconds);

// TimeSpan time = new TimeSpan(hours, minutes, seconds);

// while(time.TotalSeconds >= 0)
// {
//     Console.Write($"\rTime left : {time:hh\\:mm\\:ss}");
//     time = time.Subtract(TimeSpan.FromSeconds(1));
//     await Task.Delay(1000);
// }
// Console.WriteLine("\nTime up");

// //Calculator
// while (true)
// {
//     Console.WriteLine("\nCalculator");
//     REPEAT : 
//     Console.WriteLine("1.Addition");
//     Console.WriteLine("2.Division");
//     Console.WriteLine("3.Multiplication");
//     Console.WriteLine("4.Division");
//     Console.Write("Please choose your option : ");
//     var select = Console.ReadLine();
//     var parses = int.TryParse(select, out int selected);

//     Console.Write("Please enter your first number : ");
//     var first = Console.ReadLine();
//     parses = decimal.TryParse(first, out decimal firstNum);

//     Console.Write("Please enter your second number : ");
//     var secondNumber = Console.ReadLine();
//     parses = decimal.TryParse(secondNumber, out decimal secondNum);

//     decimal results;
//     if (selected == 1)
//     {
//         results = firstNum + secondNum;
//         Console.WriteLine($"Your Answer is {results}");
//         goto BACK;
//     }
//     else if (selected == 2)
//     {
//         results = firstNum / secondNum;
//         Console.WriteLine($"Your Answer is {results}");
//         goto BACK;
//     }
//     else if (selected == 3)
//     {
//         results = firstNum * secondNum;
//         Console.WriteLine($"Your Answer is {results}");
//         goto BACK;
//     }
//     else if (selected == 4)
//     {
//         results = firstNum - secondNum;
//         Console.WriteLine($"Your Answer is {results}");
//         goto BACK;
//     }
//     BACK : 
//     Console.Write("Do you want to continue (y/n): ");
//     var check = Console.ReadKey();
//     if (check.Key == ConsoleKey.Y) {Console.WriteLine();goto REPEAT; } 
//     else if (check.Key == ConsoleKey.N) { Console.WriteLine(); break; }
//     else goto BACK;
// }

//Age Calculator
using System.Globalization;

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
