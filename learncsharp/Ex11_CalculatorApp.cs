using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    class Calculator
    {
        public int Add(int a , int b){ return a + b; }
       // public int Add(int a, int b, int c) { return a + b + c; }

        public int Add(int a, int b, params int[] c) { 
            int sum =  a + b;
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
        public static void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Sum of two number is: " + calc.Add(4, 2));
            Console.WriteLine("Sum of 3 number is: " + calc.Add(4, 2, 1));
            Console.WriteLine("Sum of n number is: " + calc.Add(4, 2, 1,5,12,3,4,5));


        }
    }
}
