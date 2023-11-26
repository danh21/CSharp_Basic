using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ClassesAndMore
{
    partial class MyClass
    {
        private string _str = "";

        public MyClass()
        {
            _str = "A Default String";
        }

        public MyClass(string aString)
        {
            _str = aString;
        }

        public static string ToUppCase(string aString)
        {
            return aString.ToUpper();
        }

        public static string ToLowCase(string aString)
        {
            return aString.ToLower();
        }

        public static string ToLowCase(string aString, string anotherString)
        {
            return (ToLowCase(aString) + ToLowCase(anotherString));
        }

        public string ToLowCase()
        {
            return ToLowCase(_str);
        }

        private string Reverse(string aString)
        {
            string revS = "";
            for (int i = aString.Length - 1; i >= 0; i--)
                revS += aString[i];
            return revS;
        }

        public string ToReversedLowCase()
        {
            return (Reverse(ToLowCase(_str)));
        }
    }
}
