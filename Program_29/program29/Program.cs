using System;

class Rect
{
    // Instance variables
    double length;
    double width;

    // Default constructor
    public Rect()
    {
        length = 0;
        width = 0;
    }

    // Parameterized constructor
    public Rect(double l, double w)
    {
        length = l;
        width = w;
    }

    //calculate area
    public double FindArea()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + FindArea());
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        
        Rect r1 = new Rect();
        Console.WriteLine("Rectangle using Default Constructor:");
        r1.Display();

        Rect r2 = new Rect(10, 5);
        Console.WriteLine("Rectangle using Parameterized Constructor:");
        r2.Display();
    }
}
