//input from user perform all relational operator and display correct output
using System;

class Program
{
    static void Main()
    {
        int a, b;

        Console.Write("Enter Value 1 : ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter Value 2 : ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("A Greater than B : " + (a > b));
        Console.WriteLine("A Less than B : " + (a < b));
        Console.WriteLine("A Greater than equal to B : " + (a >= b));
        Console.WriteLine("A Less than equal to B : " + (a <= b));
        Console.WriteLine("A not equal to B : " + (a != b));
    }
}