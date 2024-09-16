using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    internal class Ex07_EvenNumbers
    {
        
        public  void Main()
        {
            string[] employees = new string[] { "HR", "IT", "contract", "DeV", "QA" };
            //
            int i = 0;
            do {
                if (employees[i] == "contract")
                {
                    i++;
                    continue; // --> it goes to the start of the loop
                }
                Console.WriteLine(employees[i]);
                i++;
            }while (i < employees.Length);
        }
    }
}
