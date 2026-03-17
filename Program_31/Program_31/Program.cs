using System;

class Employee
{
    int employeeId;
    string name;
    double salary;

    public Employee()
    {
        employeeId = 102;
        name = "Heet";
        salary = 500000;
    }

    public Employee(int id, string n, double s)
    {
        employeeId = id;
        name = n;
        salary = s;
    }

    public double CalculateAnnualSalary()
    {
        return salary * 12;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Monthly Salary: " + salary);
        Console.WriteLine("Annual Salary: " + CalculateAnnualSalary());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee(101, "Amit", 30000);

        Employee e2 = new Employee();

        Console.WriteLine("Employee 1 Details:");
        e1.DisplayInfo();

        Console.WriteLine("\nEmployee 2 Details:");
        e2.DisplayInfo();
    }
}