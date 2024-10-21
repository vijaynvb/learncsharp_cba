using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp // namepace
{

    // person student teacher
    class MyClassNew
    {
        public int Id { get; set; }
    }

    class Person
    {
        internal int Id { get; set; }
        public string Name { get; set; }
        public string AadharID { get; set; }
        // functions 
        public virtual void display()
        {
            Console.WriteLine("My Name is :" + Name);
        }
    }

    class Student : Person
    {
        /*        public int Id { get; set; }
                public string Name { get; set; }
                public string AadharID { get; set; }*/
        public int studentId { get; set; }
        public override void display()
        {
            Console.WriteLine("My Name is :" + Name + " Sudent id: " + studentId);
        }
    }

    class DistanceStudent: Student
    {
        string curriculumtype = "distance";

    }

    class FulltimeStudent: Student
    {
    }

    public class Ex17_Inheritance
    {

        public  void Main()
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "vijay";
            student.AadharID = "123123";
            student.studentId = 1;

            Person p = new Person();
            p.Name = "vj";
            p.display();

            Person p1 = new Student();
            p1.Name = "jai";
            p1.display();

        }
    }
}
