public class Calculator()
{
    int selected;
    decimal firstNum;
    decimal secondNum;
    decimal results;

    public void Mains()
    {
        Menu();
        MainImp();
    }
    public void Menu()
    {
        Console.WriteLine("\nCalculator");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Division");
        Console.WriteLine("3.Multiplication");
        Console.WriteLine("4.Subtraction");
        Console.Write("Please choose your option : ");
        var select = Console.ReadLine();
        var parses = int.TryParse(select, out selected);
    }

    public void Values()
    {
        Console.Write("Please enter your first number : ");
        var first = Console.ReadLine();
        var parses = decimal.TryParse(first, out firstNum);

        Console.Write("Please enter your second number : ");
        var secondNumber = Console.ReadLine();
        parses = decimal.TryParse(secondNumber, out secondNum);
    }
    public void Add()
    {
        results = firstNum + secondNum;
        Console.WriteLine($"Your Answer is {results}");
    }
    public void Subtract()
    {
        results = firstNum - secondNum;
        Console.WriteLine($"Your Answer is {results}");
    }
    public void Multiplication()
    {
        results = firstNum * secondNum;
        Console.WriteLine($"Your Answer is {results}");
    }
    public void Div()
    {
        results = firstNum + secondNum;
        Console.WriteLine($"Your Answer is {results}");
        if (secondNum == 0)
        {
            Console.WriteLine($"Your Answer is undefined");
        }

        results = firstNum / secondNum;
        Console.WriteLine($"Your Answer is {results}");

    }
    public void MainImp()
    {
        if (selected == 1)
        {
            Add();
        }
        else if (selected == 2)
        {
            Div();
        }
        else if (selected == 3)
        {
            Multiplication();
        }
        else if (selected == 4)
        {
            Subtract();
        }
    }
}