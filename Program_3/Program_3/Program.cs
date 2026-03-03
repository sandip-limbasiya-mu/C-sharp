//w.a.p to input 2 number and an arithmetic operator , display the result 
using System;

namespace App
{

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter no 1 : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter no 2 : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));

        }
    }
}