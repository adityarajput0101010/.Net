using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Task Started");

        await Work();

        Console.WriteLine("Task Completed");
    }

    static async Task Work()
    {
        await Task.Delay(3000);
        Console.WriteLine("Working...");
    }
}