using System;

class Account
{
    protected int accountNumber;
    protected double balance;

    public Account(int accNo, double bal)
    {
        accountNumber = accNo;
        balance = bal;
    }

    public virtual void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
        Console.WriteLine("Balance: " + balance);
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : Account
{
    private double interestRate;

    public SavingsAccount(int accNo, double bal, double rate)
        : base(accNo, bal)
    {
        interestRate = rate;
    }

    public void AddInterest()
    {
        double interest = balance * interestRate / 100;
        balance += interest;
        Console.WriteLine("Interest added: " + interest);
        Console.WriteLine("Balance: " + balance);
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Savings: " + amount);
        }
        else
        {
            Console.WriteLine("Savings account: Insufficient balance!");
        }
        Console.WriteLine("Balance: " + balance);
    }
}

class CurrentAccount : Account
{
    private double overdraftLimit;

    public CurrentAccount(int accNo, double bal, double limit)
        : base(accNo, bal)
    {
        overdraftLimit = limit;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance + overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Current: " + amount);
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded!");
        }
        Console.WriteLine("Balance: " + balance);
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(101, 5000, 5);
        CurrentAccount ca = new CurrentAccount(102, 3000, 2000);

        Console.WriteLine("---- Savings Account ----");
        sa.Deposit(1000);
        sa.Withdraw(2000);
        sa.AddInterest();

        Console.WriteLine("\n---- Current Account ----");
        ca.Deposit(500);
        ca.Withdraw(4000);
    }
}