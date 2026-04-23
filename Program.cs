using System;

class Student
{
    private string name;

    public void SetName(string n)
    {
        name = n;
    }

    public void ShowName()
    {
        Console.WriteLine("Student Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.SetName("Shishir");
        s.ShowName();
    }
}