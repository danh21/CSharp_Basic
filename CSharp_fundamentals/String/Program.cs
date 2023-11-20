using System;

namespace String
{
    class Program
    {
        /* ---------------------------------------- Main ---------------------------------------- */
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string s = Console.ReadLine();

            Console.WriteLine("String after removing number: " + rmNum(s));

            Console.WriteLine("The number of uppercase letters: " + cntUpLetter(s));

            Console.WriteLine("Reverse string: " + reverse(s));


            Console.Write("Enter the character: ");
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine("The number of characters equal to '" + c + "': " + cntElementEqChar(s, c));

            if (searchElement(s, c) != -1)
                Console.WriteLine("The index of '" + c + "' is: " + searchElement(s, c));
            else
                Console.WriteLine("No character found !!!");


            Console.Write("Enter the second string: ");
            string s2 = Console.ReadLine();

            Console.WriteLine("Index of \"" + s2 + "\" in \"" + s + "\": " + s.ToLower().IndexOf(s2.ToLower()));
        }



        /* ---------------------------------------- APIs ---------------------------------------- */
        public static int cntElementEqChar(string str, char ch)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ch)
                    count++;
            return count;
        }



        public static int searchElement(string str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ch)
                    return i;
            return -1;
        }



        public static string rmNum(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (str[i] >= '0' && str[i] <= '9')
                    str = str.Replace(str[i--] + "", "");
            return str;
        }



        public static int cntUpLetter(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                    continue;
                if (str[i] == str.ToUpper()[i])
                    count++;
            }
            return count;
        }



        public static string reverse(string str)
        {
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
                rev += str[i];
            return rev;
        }
    }
}