using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{

    public class Employee
    {
        // variables
        public int Id;
        public string Name;
        public int Age;
        // methods
        // class specific methods 
        // constructors and destructors 
        public Employee() // default no parameters 
        {
        }

        public Employee(int id, int age, string name)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        // user defined methods 
        public string getEmployeeName()
        {
            string str = "Employee Name is : " + Name;
            return str;
        }

        public void setAge(int age)
        {
            Age = age;
        }

    }

 
    
    
    // Manager or Runner Class
    public class Ex09_ClassesObjects
    {
        public  void Main()
        {
            // datatype variablename 
            // int a
            Employee emp1 = new Employee(); // memory allcation 
            emp1.Id = 1;
            emp1.Name = "vijay";
            emp1.Age = 18;

            Console.WriteLine(emp1.Age);

            emp1.setAge(19);

            Console.WriteLine(emp1.Age);

            Employee emp2 = new Employee(2,12,"jai"); // memory allcation 
            Console.WriteLine(emp1.getEmployeeName());
        }

        /*
         *  EMployee
         *      vijay - features -> address -> methods
         *      jai
         * 
         */
    }
}
