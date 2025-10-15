//Time Counter.
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

while(time.TotalSeconds >= 0)
{
    Console.Write($"\rTime left : {time:hh\\:mm\\:ss}");
    time = time.Subtract(TimeSpan.FromSeconds(1));
    await Task.Delay(1000);
}
Console.WriteLine("\nTime up");
