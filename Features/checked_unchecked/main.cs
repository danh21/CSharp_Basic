using System;

class Program
{
    static void Main(string[] args)
    {
        CheckedUnchecked();
    }

    static void CheckedUnchecked()
    {
        int x = int.MaxValue;

        // This will silently overflow
        unchecked
        {
            Console.WriteLine("Unchecked: " + (x + 1)); // Wraps around to int.MinValue
        }

        // This will throw an OverflowException
        checked
        {
            Console.WriteLine(x + 1); // Exception
        }
    }
}
