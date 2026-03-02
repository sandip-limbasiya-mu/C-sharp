using System;
using System.Transactions;

class Program
{ 
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        int max;
        Console.WriteLine("Enter 5 numbers : ");
        for (int i = 0; i < 5; i++)
        {
            arr[i] = Connvert.ToInt32(Console.ReadLine());

        
        max = arr[0];
        for (int i = 1; i < 5; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            
        }
        Console.WriteLine("The maximum number is : " + max);
    }
}
