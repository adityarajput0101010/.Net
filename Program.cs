using System;

class Report
{
    public string GetData()
    {
        return "Monthly Sales Report";
    }
}

class Printer
{
    public void Print(string data)
    {
        Console.WriteLine(data);
    }
}

class Program
{
    static void Main()
    {
        Report r = new Report();
        Printer p = new Printer();

        p.Print(r.GetData());
    }
}