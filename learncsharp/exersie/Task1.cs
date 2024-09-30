using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp.exersie
{
    // write a program to accept two number and do addition, subtraction, division, multiplication
    // and print your outputs.
    delegate int CalculatorDelegate(int a, int b);
    class Calculator
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
    class Task1
    {
        // Step 1: educate user to provide inputs
        // step 2: accept two numbers
        // step 3: do addition
        // step 4: do sub
        // step 5: do div
        // step 6: do mul
        // step 7: print the output for end user

        public static int defaultOperation(int a,int b)
        {
            Console.WriteLine("Noting to do");
            return 0;
        }

        public static void Main()
        {
            Calculator calc = new Calculator();
            CalculatorDelegate calculator;
            Console.WriteLine("Which opertaion do you want to do?\n1- Add\n2- Sub\n3- Div\n4- Mul\n ENter ur Option:");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    calculator = new CalculatorDelegate(calc.add);
                    break;
                case 2:
                    calculator = new CalculatorDelegate(calc.sub);
                    break;
                case 3:
                    calculator = new CalculatorDelegate(calc.div);
                    break;
                case 4:
                    calculator = new CalculatorDelegate(calc.mul);
                    break;
                default:
                    calculator = new CalculatorDelegate(defaultOperation);
                    break;
            }

            if(calculator != null)
               Console.WriteLine("Calculated value is: "+calculator(5, 6));
        }
    }
}
