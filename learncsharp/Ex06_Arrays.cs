using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    internal class Ex06_Arrays
    {
        public  void Main()
        {
            int[] arr = new int[3]; // 0 will be intial value in each element, index 0,1,2
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = { 1, 2, 3 };

            arr[0] = 1;
            Console.Write(arr[3]); // 0,1,2,3

            // loops , for, while, do while, foreach


            //for(intialize ; condition ; increment)

            for(int j = 0; j < arr.Length; j++) // unary i=i+1
            {
                // execute the staements in the for block

                Console.Write(arr[j]);
            }
            for(int a = 1, b =2  ; a < 10 && b < 20 ; a+=2,b+=4) // a=3, b=6, a=5,b=10, a=7,b=14,a=9,b=18
            {
                Console.WriteLine("heloo");
            }

            int i = 0;
            while(i< arr.Length) // 0 < 3, 1 < 3, 2 < 3, 3 < 3
            {
                Console.Write(arr[i]);
                i++;
            }

            string str = null;
            do
            {
                Console.Write(str.Replace("h", "l")); // 0,
            } while (str != null);

        }
    }
}
