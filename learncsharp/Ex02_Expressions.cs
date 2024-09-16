using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    class Ex02_Expressions
    {
        public  void Main()
        {
            Console.WriteLine("Expressions example");

            int a = 10, b = 20, c; // cvalue is 0

            c = a + b; // 30

            a += b; // 30

            a++; // 31

            Console.WriteLine("output is :" + a);
            Console.WriteLine("output is :{0}", a+b+c); // + operator overloading 
            Console.WriteLine($"output of a:{a} b:{b} c:{c}"); // interpolation 

            Console.WriteLine("output of a:{0} b:{1} c:{3}",a,b,c,10); //0,1,2,3 // interpolation with index

            Console.WriteLine(@"C:\Dev\Readme.txt"); // \n \r \t \b \0

        }
    }
}
