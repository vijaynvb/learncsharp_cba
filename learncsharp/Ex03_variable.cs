
namespace myNamespace{
    
    class myClass{
        int a = 10; // scope of the variable is with in the block , local variable 
        int b = 20;

    public  void Main()
        {
            int a=5;
        }
        void myMethod()
        {
            int b = 10;
            Console.WriteLine(b);
        }
        void myMethod1()
        {
             Console.WriteLine(b);
        }
        void myMethod2()
        {
            int b = 10;
        }

    }
}