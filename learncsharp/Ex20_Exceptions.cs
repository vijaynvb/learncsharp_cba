using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncsharp
{

    public class EmplyeeAgeCriteriaException : Exception
    {
        public EmplyeeAgeCriteriaException(string message) : base(message)
        {
        }
    }

    internal class Ex20_Exceptions
    {

        public static void Main()
        {
            int userOption = 0;
            // try catch finally throw
            while (userOption != 5)
            {
                int[] a = new int[2] { 1, 2 };
                int age = 18;
                try
                {
                    // we write all the code where we feel like exceptions can happen
                    Console.Write("Enter your option: ");
                    userOption = Convert.ToInt32(Console.ReadLine());
                    int b = a[userOption];
                    Console.WriteLine("my input: " + userOption);
                    if (age == 18)
                        throw new EmplyeeAgeCriteriaException("Age should be less than ");

                    // n no of statements 

                }
                catch (EmplyeeAgeCriteriaException ex)
                {
                    Console.WriteLine(ex.Message); // error message of a given exception
                    Console.WriteLine(ex.StackTrace); // gives the error descriptions how it got invoked 
                    Console.WriteLine(ex.Source); // in which line the exception happend
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Index is out of range keep it below: " + (a.Length - 1));
                }
                catch (FormatException ex)
                {
                    // hande the exceptions
                    Console.WriteLine("only number are allowed");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("exception occured contact developer");
                }
                finally
                {

                }
                // continue working 
                Console.WriteLine("outside try block");
            }
        }
    }


    class ReadFile
    {
        public void Main()
        {
            try
            {
                // open a file c:/readme.txt
                // read
                // error
                // write on console 
            }
            catch (Exception ex)
            {

            }
            finally {
            // close()}
            
        }

    }
}
