using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;

            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine("Message: " + ex.Message);
        }

        Console.WriteLine("Program continues after exception handling.");
    }
}