using System;

namespace Loop {
    class Program {
        /* ------------------------------------------ Main ------------------------------------------ */
        static void Main(string[] args) {
            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int m = int.Parse(Console.ReadLine());
            int[, ] arr = new int[n, m];

            // Input
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    arr[i, j] = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of all elements: " + sumOfArr(arr));

            int sum = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (arr[i, j] % 5 == 0)
                        sum += arr[i, j];
            Console.WriteLine("Sum of all elements divisible by 5: " + sum);         
		}



        /* ------------------------------------------ APIs ------------------------------------------ */
        public static int sumOfArr(int[, ] arr) {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    sum += arr[i, j];
            return sum;
        }
    }
}
