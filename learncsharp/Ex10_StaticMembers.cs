using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    class MyClass
    {
        public int x = 10;
        public static int y=20;

        // methods
        //  access specifier return methodname(parameter o or more paramenters){ defnition }

        // methods defnition 

        public void myMethod(int a, int b) // 0 
        {
            Console.WriteLine( a + b);
        }

        public void someMethod()
        {
            myMethod(1,2);
        }
        // method call


    }

    internal class Ex10_StaticMembers
    {
        public void myMehotd()
        {
            Console.WriteLine(MyClass.y);
        }

        public  void Main()
        {
            Console.WriteLine(MyClass.y);
            // object
            MyClass myObject = new MyClass();
            myObject.x = 25;
            Console.WriteLine(myObject.x);

            myObject.myMethod(1,1);

            //object 1
            MyClass myObject1 = new MyClass();
            myObject1.x = 30;
            Console.WriteLine(myObject1.x);


        }
    }
}
