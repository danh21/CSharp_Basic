using System;

namespace Method {
    class Program {
        /* ---------------------------------------- Main ---------------------------------------- */
        static void Main(string[] args) {

            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial of " + n + ": " + Factorial(n));

            Console.WriteLine("The sum of all odd numbers from 1 to " + n + ": " + sumOdd(n));

            if (isEven(n))
                Console.WriteLine(n + " is an even number");
            else
                Console.WriteLine(n + " is an odd number");

            // int a = int.Parse(Console.ReadLine());
            // int b = int.Parse(Console.ReadLine());
            // int c = int.Parse(Console.ReadLine());
            // Console.WriteLine("Max: " + Max3(a, b, c));
        }



        /* ---------------------------------------- APIs ---------------------------------------- */
        public static bool isEven(int n) {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }

        public static int Factorial(int n) {
            if (n == 1 || n == 0) 
                return 1;
            return n * Factorial(n - 1);
        }

        public static int sumOdd (int n) {
            if (n == 1) 
                return 1;
            if (n % 2 == 0)
                return sumOdd(n-1);
	        else
                return n + sumOdd(n - 1);
        }

        public static int Max3(int a, int b, int c) {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }
    }
}