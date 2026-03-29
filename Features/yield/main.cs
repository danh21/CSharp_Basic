using System;
using System.Collections.Generic;

class Program
{
    // Iterator method using yield
    static IEnumerable<int> range(int from, int to)
    {
        for (int i = from; i < to; i++)
        {
            yield return i; // pauses the function and returns one value at a time.
        }
    }

    static void Main(string[] args)
    {
        foreach (int i in range(-10, 10))
        {
            Console.WriteLine(i);
        }
    }
}
