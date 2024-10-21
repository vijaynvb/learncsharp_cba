using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    internal class Ex16_PredifinedDelegate
    {
        public static List<int> numbers = new List<int> { 1, 2, 3 };

        /*       public static int Find(Predicate<int> a) // function a => a==2
               {
                    foreach(int i in numbers)
                    {
                        if(a(i))
                            return i;
                    }
                    return 0;
               } */
        public static Boolean somePredicateFunction(int a) {
            return a == 2; // 1 == 2
        }

        public  void Main()
        {
           //numbers.ForEach(a => Console.WriteLine(a));
            /*Predicate<int> predicate;
            predicate =new Predicate<int>( a => a == 2);
            predicate(1);*/


           int result = numbers.Find((int a) => { return a == 2; });
            Console.WriteLine(result);
            //int result = Find(somePredicateFunction);
        }
    }
}
