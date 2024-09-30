using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{

    internal class Ex15_Delegates
    {
        delegate void Notifier(string message);
        public  void sayHello(string message)
        {
            Console.WriteLine("Hello " + message);
        }
        public  void sayBye(string message)
        {
            Console.WriteLine("Bye " + message);
        }


        public  void Main()
        {
            Ex15_Delegates myobj=new Ex15_Delegates();
            Notifier greetings;
            /*if (DateTime.Now.Hour < 10)
                greetings = new Notifier(myobj.sayHello); // methods 
            else
                greetings = new Notifier(myobj.sayBye);*/

            greetings = new Notifier(myobj.sayHello);
            greetings += new Notifier(myobj.sayBye);

            greetings("vijay");

        }
    }
}
