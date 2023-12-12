using System;

namespace CsharpDates;

class Program
{
    static void Main(string[] args)
    {
        var dateTime = new DateTime(2023, 1, 1);
        var now = DateTime.Now;
        var today = DateTime.Today;

        Console.WriteLine("Hour: " + now.Hour);
        Console.WriteLine("Minute: " + now.Minute);

        var tomorrow = now.AddDays(1);
        //the negative will make it so you get the day before date
        var yesterday = now.AddDays(-1);
        


        Console.WriteLine(now.ToLongDateString());

        Console.WriteLine(now.ToShortDateString());

        Console.WriteLine(now.ToLongDateString());
         
        Console.WriteLine(now.ToShortDateString()); 

        Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); //12 / 12 / 2023 12:51:55 PM

    }
}

