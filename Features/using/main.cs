using System;
using System.IO;

class Program
{
    static void UsingStatement(string[] args)
    {
        // "using" ensures that the TextWriter is properly disposed of after use
        using (TextWriter w = File.CreateText("out.txt"))
        {
            w.WriteLine("Line one");
            w.WriteLine("Line two");
            w.WriteLine("Line three");
        }

        Console.WriteLine("File 'out.txt' written successfully.");
    }

    static void Main(string[] args)
    {
        UsingStatement(args);
    }
}
