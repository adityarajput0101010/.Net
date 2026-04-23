using System;

delegate int MyDelegate(int a, int b);

class Program
{
    static void Main()
    {
        MyDelegate add = (x, y) => x + y;

        Console.WriteLine("Addition = " + add(10, 20));
    }
}