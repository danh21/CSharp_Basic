using System;

namespace MethodTest
{
    class A
    {
        public String method1()
        {
            return "class A: method1\r\n";
        }

        public virtual String method2()
        { // class A
            return "class A: (virtual) method2\r\n";
        }

        public String method3()
        {
            return "class A: method3\r\n";
        }
    }



    // class A is the ancestor of class B  
    class B : A
    {
        public new String method1() // note 'new' keyword 
        {
            return "class B: (new) method1\r\n";
        }

        public override String method2()
        {
            return "class B: (override) method2\r\n";
        }

        public String method3()
        {
            return "class B: method3\r\n";
        }
    }

}
