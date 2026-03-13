using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];
        int sum = 0;
        double average;

        Console.WriteLine("Enter marks of 5 students:");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            sum = sum + marks[i];
        }
        average = sum / 5.0;

        Console.WriteLine("Total Marks = " + sum);
        Console.WriteLine("Average Marks = " + average);
    }
}