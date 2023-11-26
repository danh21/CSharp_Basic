using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringops
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            s += " World";

            Char[] TrimChars = { ' ', '*', '-' };
            StringBuilder sb = new StringBuilder("Hello World");

            Console.WriteLine("1  " + s.ToUpper());
            Console.WriteLine("2  " + s.ToLower());
            Console.WriteLine("3  " + s.PadLeft(30));
            Console.WriteLine("4  " + s.PadLeft(30, '-'));
            Console.WriteLine("5  " + s.PadRight(30, '*'));
            Console.WriteLine("6  " + s.IndexOf("World"));
            Console.WriteLine("7  " + s.IndexOf("Moon"));
            Console.WriteLine("8  " + s.Replace("World", "Moon"));
            Console.WriteLine("9  " + s);

            // --- StringBuilder
            Console.WriteLine("10 " + sb.Replace("World", "Moon"));
            Console.WriteLine("11 " + sb);
            sb.Append(" - and goodbye");
            Console.WriteLine("12 " + sb);

            s = "         " + s + "-*-*-";
            Console.WriteLine("13 " + s);
            Console.WriteLine("14 " + s.TrimStart());
            Console.WriteLine("15  " + s.TrimEnd(TrimChars));
            Console.WriteLine("16  " + s.Trim(TrimChars));
        }
    }
}
