using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{


    class Emp // implicit constructor 
    {
        int a, b, c;
        // types of methods 

        // constructors same name of the class

        // overloading methods with paramenter 
        public Emp():this(-1,-1)
        { 
        }
        public Emp(int a): this(a,-1)
        {
        }
        public Emp(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        // nomarl methods
        // overloaded methods
        public void InvokeMe()
        {
            InvokeMe(5);
            Console.WriteLine("Hello world");
        }
        public void InvokeMe(int a)
        {
            Console.WriteLine("Hello world");
        }
    }

    internal class Ex12_Methods // runner class - UI
    {
        public  void Main()
        {
            Emp emp = new Emp();
            Emp emp1 = new Emp(5);
            Emp emp2 = new Emp(5,10);
        }

    }
}
