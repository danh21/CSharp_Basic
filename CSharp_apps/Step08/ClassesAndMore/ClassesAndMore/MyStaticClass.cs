using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAndMore
{
    static class MyStaticClass
    {
        public static string toUppCase(string aString)
        {
            return aString.ToUpper();
        }

        // This isn't allowed
        //public string toLowCase( string aString ) {
        //    return aString.ToLower( );
        //}
    }
}
