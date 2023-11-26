using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringinterpolation
{
    class Program
    {

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            string s = "";
            string mystring = "Test";

            // Format strings
            s = String.Format("{0} of String.Format(): 1+2 = {1}. {2}. {3}", mystring, 1 + 2, "hello world".ToUpper(), Multiply(10, 5));
            Console.WriteLine(s);
            s = String.Format("{5} {4} {3} {2} {1} {0} {5} {4} {3} ", 1, 2, 3, 4, 5, 6);
            Console.WriteLine(s);

            // s = String.Format("{1} {2} {3} {4} {5} {6}", 1, 2, 3, 4, 5, 6); // This is an error!
            // Console.WriteLine(s);

            // String interpolation        
            s = $"(a) {mystring} of string interpolation: 1+2 = {1 + 2}. {"hello world".ToUpper()}. {Multiply(10, 5)}";
            Console.WriteLine(s);

            // ---- An 'aside' on Console.WriteLine() ----
            // Console.WriteLine() lets you use format strings (as shown below) without using String.Format()             
            // So this works... (because Format strings are automatically evaluated)
            Console.WriteLine("(b) {0} (format string): 1+2 = {1}. {2}. {3}", mystring, 1 + 2, "hello world".ToUpper(), Multiply(10, 5));

            // This doesn't work... (because interpolated strings are not automatically evaluated)
            //      Console.WriteLine("(c) {mystring}: 1+2 = {1 + 2}. {"hello world".ToUpper()}. {Multiply(10, 5)}");

            // This works... (because interpolated strings are evaluated when preceded by a $)
            Console.WriteLine($"(d) {mystring} of string interpolation: 1+2 = {1 + 2}. {"hello world".ToUpper()}. {Multiply(10, 5)}");

            s = "\nThis is a \t{mystring}\n";       // regular string
            Console.WriteLine(s);
            s = $"\nThis is a \t{mystring}\n";      // string interpolation
            Console.WriteLine(s);
            s = @"\nThis is a \t{mystring}\n";      // verbatim string
            Console.WriteLine(s);
        }
    }
}
