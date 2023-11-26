using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAndMore
{
    partial class MyClass
    {

        public static string Capitalize(string aString)
        {
            string s = ToLowCase(aString.Substring(1, aString.Length - 1));
            char firstchar = char.ToUpper(aString[0]);
            return firstchar + s;
        }

    }

}
