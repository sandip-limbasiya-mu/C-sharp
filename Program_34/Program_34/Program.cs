using System;

interface IPass
{
    bool Pass(int mark);
}

interface IDivision
{
    string Division(int average);
}

class Result : IPass, IDivision
{
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else if (average >= 40)
            return "Third Division";
        else
            return "Fail";
    }
}

class Program
{
    static void Main()
    {
        Result obj = new Result();

        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter average: ");
        int avg = Convert.ToInt32(Console.ReadLine());

        bool result = obj.Pass(marks);
        string division = obj.Division(avg);

        Console.WriteLine("Pass Status: " + result);
        Console.WriteLine("Division: " + division);
    }
}