// w.a.p to input radius of a circle and print area of that circle
using System;

class Program
{
    static void Main(string[] args)
    {
        double r, area;

        Console.Write("Enter radius: ");
        r = double.Parse(Console.ReadLine());

        area = 3.14 * r * r;

        Console.WriteLine("Area of circle = " + area);
    }
}