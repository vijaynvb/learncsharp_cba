using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp.exersie
{
    // write a program to accept two number and do addition, subtraction, division, multiplication
    // and print your outputs.

    /*    class Calculator
        {
            public int add(int a, int b)
            {
                return a + b;
            }
            public int sub(int a, int b)
            {
                return a - b;
            }
            public int div(int a, int b)
            {
                return a / b;
            }
            public int mul(int a, int b)
            {
                return a * b;

            }
        }

    */
    class Task1
    {
        delegate int CalculatorDelegate(int a, int b);
        public  void Main()
        {
           // Calculator calc = new Calculator();
            CalculatorDelegate calculator;
            Console.WriteLine("Which opertaion do you want to do?\n1- Add\n2- Sub\n3- Div\n4- Mul\n ENter ur Option:");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    calculator = new CalculatorDelegate((int a ,int b) => { return a + b; });
                    break;
                case 2:
                    calculator = new CalculatorDelegate((int a, int b) => { return a - b; });
                    break;
                case 3:
                    calculator = new CalculatorDelegate((int a, int b) => { return a / b; });
                    break;
                case 4:
                    calculator = new CalculatorDelegate((int a, int b) => { return a * b; });
                    break;
                default:
                    calculator = new CalculatorDelegate((int a, int b)=> { Console.WriteLine("not valid"); return 0; });
                    break;
            }
            Console.WriteLine("Calculated value is: " + calculator(5, 6));
        }
    }
}
