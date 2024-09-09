// See https://aka.ms/new-console-template for more information

// opinionated view 

namespace learncsharp
{
    class Ex01_ReadWrite
    {
        public void Main()
        {
            Console.WriteLine("Enter your optins as integer!"); 
            string strInput = Console.ReadLine();
            int myOption = Convert.ToInt32(strInput);
            //int myOption2 = (int) strInput;
            Console.WriteLine(myOption);
        }
    }
}


