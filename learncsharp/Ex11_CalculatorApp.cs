using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    class Calculator
    {
       // public int Add(int a , int b){ return a + b; }
       // public int Add(int a, int b, int c) { return a + b + c; }

        public int Add(params int[] c) {
            int sum = 0;
            if (c.Length > 0) {
                for (int i = 0; i < c.Length; i++)
                {
                    sum = sum + c[i];
                }     
            }
            return sum;
        }

    }
    class Ex11_CalculatorApp
    {
        // runner class
        public  void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Sum of two number is: " + calc.Add(4, 2));
            Console.WriteLine("Sum of 3 number is: " + calc.Add(4, 2, 1));
            Console.WriteLine("Sum of n number is: " + calc.Add(4, 2, 1,5,12,3,4));

            Console.WriteLine(@"print a {0}, b {0} c {0} ...{5}", 1, 2, 3,4,5,6,8);
        }
    }
}
