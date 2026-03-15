// w.a.p to input principal amount , rate and year and display compound interest 

using System;

class Program
{
    static void Main()
    {
        double p, r, y, ci;

        Console.Write("Enter Principal Amount: ");
        p = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        r = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        y = double.Parse(Console.ReadLine());

        ci = p * Math.Pow((1 + r / 100), y) - p;

        Console.WriteLine("Compound Interest : " + ci);
    }
}
