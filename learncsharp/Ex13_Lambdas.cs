using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{

    class Calc
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int increment(int a)
        {
            return a++;
        }

    }
    internal class Ex13_Lambdas
    {
        public  void Main()
        {
            Calc calc = new Calc();
            Console.WriteLine( calc.add(1, 2));
            var myadd = (int a, int b) => { return a - b; };
            // () => {}
            var myincrement = (int a) => { return ++a; };

            Console.WriteLine(myadd(5, 6));
            Console.WriteLine(myincrement(5));

        }
    }


    // delegates are special data types function pointers 
}
