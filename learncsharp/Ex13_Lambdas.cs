using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    delegate int CalcBasic(int x, int y);
    delegate int CalcIncrement(int x);
    delegate void Notifier(string message);

    
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
            Calc c = new Calc();
            CalcBasic addition = new CalcBasic((int a, int b)=>{return a + b;});
            CalcBasic addition1 = new CalcBasic((a,b) => {
                Console.WriteLine("hell0");
                return a + b;
            });
            CalcBasic addition2 = new CalcBasic((a, b) =>  a + b );

            CalcBasic addition3 = new CalcBasic((a, b) => a + b);

            CalcIncrement incement = new CalcIncrement((int a) => { return ++a; });

            CalcIncrement incement1 = new CalcIncrement((a) => { return ++a; });

            CalcIncrement incement2 = new CalcIncrement((a) => ++a);

            CalcIncrement incement3 = new CalcIncrement( a => ++a);

            Notifier greetings = new Notifier(msg => Console.WriteLine("Hello" + msg));
            greetings("vijay");

            addition(3, 4);



        }

        // Func, Action, Predicates -> C#.net

        // Func -> take multiple params and return as per data type 

       // deletgate int Func(int a, int b);

        // Action -> take multiple param and return nothing 

        //delegate void Action(int a, int b);

        // Predicate -> take multiple params and return boolean value only 

        //delegate bool Predicate(int a, int b);

        // collection will use these three predefined delegates 
    }

}
