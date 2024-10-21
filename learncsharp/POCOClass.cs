using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{

    // poco = standard -> framewrok asp.net, validation framework, collection framework, DI framework .....
    class Empl
    {
        public Empl()
        {

        }

        // propertires

        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Empl(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override bool Equals(object? obj)
        {
            return obj is Empl empl &&
                   Id == empl.Id &&
                   Name == empl.Name &&
                   Age == empl.Age;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Age);
        }

        public override string? ToString()
        {
            return base.ToString();
        }

    }



    internal class POCOClass
    {

        public static void Main()
        {
            Empl empl = new Empl();
            empl.Age = 22;
            Console.WriteLine(empl.Id);


            Empl empl1 = new Empl();


            if (empl == empl1) // 20000 == 30000
                Console.WriteLine("both are equal");

            bool isEqual =  empl.Equals(empl1); 
        }
    }
}
