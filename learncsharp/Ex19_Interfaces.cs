using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{


    public interface StudentCrud // contract 
    {
        public void AddStudent(string name);
    }

    internal class StudentMy : StudentCrud // by some developer
    {
        public void AddStudent(string name)
        {
            // implementation - defnition 
        }
    }

    class Runner // some devoper console
    {
        public  void Main()
        {

            StudentCrud student = new StudentMy();

            student.AddStudent("vijay");

        }
    }

    class RunnerWebUI // some devoper Web Application
    {
        public  void Main()
        {

            StudentCrud student = new StudentMy();

            student.AddStudent("vijay");

        }
    }
}
