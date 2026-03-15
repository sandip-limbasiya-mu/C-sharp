
using System;

class Program
{
    static void Main()
    {
        int p, r, t, si;

        Console.Write("Enter Principal: ");
        p = int.Parse(Console.ReadLine());

        Console.Write("Enter Rate: ");
        r = int.Parse(Console.ReadLine());

        Console.Write("Enter Time: ");
        t = int.Parse(Console.ReadLine());

        si = (p * r * t) / 100;

        Console.WriteLine("Simple Interest = " + si);
    }
}