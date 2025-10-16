using System.Globalization;
using System.Runtime.CompilerServices;

public class Age
{
    TimeSpan newDate;
    DateTime dob;
    string? input;
    decimal year;decimal month;decimal months;decimal day;
    public void Receive()
    {
        Console.Write("Enter date of birth (eg:yyyy-MM-dd): ");
        input = Console.ReadLine();
        //Console.WriteLine(input);
        Console.WriteLine($"You are {Math.Round(year)} years, {Math.Round(months)} months, and {Math.Round(day)} days old.");
    }

    public void Calc()
    {
        if (input == null || input.Trim() == "")
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            dob = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);

            DateTime today = DateTime.Today;
            newDate = today - dob;

        }
    }
    
    public void Calculate()
    {
        year = newDate.Days / 365;
        month = newDate.Days % 365;
        months = month / 31;
        day = months % 31;
    }
    
}

