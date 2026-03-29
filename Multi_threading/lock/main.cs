using System;
using System.Threading;

class Account
{
    private decimal balance;
    private readonly object sync = new object();

    public Account(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(decimal amount, string threadName)
    {
        lock (sync)
        {
            Console.WriteLine($"{threadName}: Attempting to withdraw {amount:C}");

            if (amount > balance)
            {
                Console.WriteLine($"{threadName}: Insufficient funds. Balance: {balance:C}");
                return;
            }

            // Simulate delay
            Thread.Sleep(100);

            balance -= amount;
            Console.WriteLine($"{threadName}: Withdrawal successful. New balance: {balance:C}");
        }
    }
}

class Program
{
    static void Main()
    {
        Account account = new Account(1000m);

        // Create threads
        Thread t1 = new Thread(() => account.Withdraw(700m, "Thread 1"));
        Thread t2 = new Thread(() => account.Withdraw(500m, "Thread 2"));
        Thread t3 = new Thread(() => account.Withdraw(300m, "Thread 3"));

        // Start threads
        t1.Start();
        t2.Start();
        t3.Start();

        // Wait for threads to finish
        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("All threads completed.");
    }
}
