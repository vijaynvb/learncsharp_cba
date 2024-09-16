using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{
    internal class Ex05_Switchcase
    {
        
        public static  void Main()
        {
            int userOption = 0;
            int NoOfEmployees = 0;
            //int[] emplist = new int[10];
            Employee[] employees = new Employee[10];
            do //infinite
            {
                Console.WriteLine("EMS - Perform below Operstions\n");
                Console.WriteLine("1-Add\n2-Get\n3-update\n4-delete\n5-exit\n");
                Console.Write("select your option: ");
                userOption = Convert.ToInt32(Console.ReadLine());
                #region :: if else example ::
                /*if(userOption == 1)
                    Console.Write("Adding User");
                else if(userOption == 2)
                    Console.Write("Get User");
                else if(userOption == 3)
                    Console.Write("Update User");
                else if(userOption == 4)
                    Console.Write("Delete User");
                else if (userOption == 5)
                    Console.Write("Thank You");*/
                // string str = "hello";
                #endregion
                switch (userOption) // data type 
                {
                    case 1:
                        Console.Write("Adding Employee\n");
                        Employee employee = new Employee();
                        employee.Name = readUserInputs("Enter Name");
                        employee.Age = Convert.ToInt32(readUserInputs("Enter Age"));
                        employee.Id = Convert.ToInt32(readUserInputs("Enter ID"));

                        employees[NoOfEmployees] = employee;
                        NoOfEmployees++;
                        break;
                    case 2:
                        Console.Write("get User");
                        break;
                    case 3:
                        Console.Write("update User");
                        break;
                    case 4:
                        Console.Write("delete User");
                        break;
                    case 5:
                        Console.Write("Thank You");
                        break;
                    default:
                        Console.Write("Not a valid Option");
                        break;
                }
            } while (userOption != 5);

        }


        public static string readUserInputs(string Prompt)
        {
            Console.Write(Prompt + " : ");
           return Console.ReadLine();
        }
    }
}
