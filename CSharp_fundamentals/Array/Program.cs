using System;

namespace Array
{
    class _Array
    {
        /* ------------------------------------------ Main ---------------------------------------------- */
        static void Main(string[] args)
        {
            /* ------------------------------------------ NUMBER ---------------------------------------------- */
            Console.Write("Enter the size of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.Write("All elements of the array: ");
            printArr(arr);

            Console.WriteLine("Max of the array: " + maxOfArr(arr));

            Console.WriteLine("Sum of the first element and last element: " + (arr[0] + arr[n - 1]));

            Console.Write("All even elements of the array: ");
            printEvenElements(arr);

            Console.WriteLine("Sum of all odd elements: " + sumOfOddElements(arr));

            Console.Write("Array after sorting ascending: ");
            sortAscending(arr);
            printArr(arr);

            Console.Write("Enter the value to compare: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("The number of elements equal to " + k + ": " + cntElementEqVal(arr, k));



            /* ------------------------------------------ STRING ---------------------------------------------- */
            /*Console.Write("Enter the size of array: ");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];

            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i < n; i++)
                arr[i] = Console.ReadLine();

            int len = 3;
            Console.WriteLine("All elements whose length greater than " + len + " of array: ");
            printStrWhoseLenGrtThanValue(arr, len);*/
        }



        /* ------------------------------------------ NUMBER APIs ------------------------------------------ */
        public static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static int maxOfArr(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }

        public static void printEvenElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static int SumOfArray(int[] arr, int size)
        {
            if (size == 1) return arr[0];
            return arr[size - 1] + SumOfArray(arr, size - 1);
        }

        public static int sumOfOddElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 != 0)
                    sum += arr[i];
            return sum;
        }

        public static void sortAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
        }

        public static int cntElementEqVal(int[] arr, int value)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == value)
                    count++;
            return count;
        }



        /* ------------------------------------------ STRING APIs ------------------------------------------ */
        public static void printStrWhoseLenGrtThanValue(string[] arr, int len)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Length > len)
                    Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
