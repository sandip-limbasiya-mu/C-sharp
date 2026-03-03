using System;

class Program
{
    static void Main()
    {
       
        int a = 10;
        float b = 5.5f;

        float result1;
        int result2;

        result1 = a + b;

        result2 = a + (int)b;


        Console.WriteLine("Integer value: " + a);
        Console.WriteLine("Float value: " + b);

        Console.WriteLine("\nAfter Automatic Conversion (a + b): " + result1);
        Console.WriteLine("After Force Conversion (a + (int)b): " + result2);
    }
}