public class Timer()
{
    int hours;
    int minutes;
    int seconds;
    TimeSpan time;
    
    public void Mains()
    {
        Times();
        Timers();
    }
    public void Times()
    {
        Console.WriteLine("Time Counter");
        Console.Write("Enter hours : ");
        var hour = Console.ReadLine();
        var parsed = int.TryParse(hour, out hours);
        Console.Write("Enter minutes : ");
        var minute = Console.ReadLine();
        parsed = int.TryParse(minute, out minutes);
        Console.Write("Enter seconds : ");
        var second = Console.ReadLine();
        parsed = int.TryParse(second, out seconds);

        time = new TimeSpan(hours, minutes, seconds);
    }

    public void Timers()
    {
        while (time.TotalSeconds >= 0)
        {
            Console.Write($"\rTime left : {time:hh\\:mm\\:ss}");
            time = time.Subtract(TimeSpan.FromSeconds(1));
            Task.Delay(1000).Wait();
        }
        Console.WriteLine("\nTime up");
    }
}