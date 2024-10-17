using System;
namespace ques_6_exception_handling
{
    internal class Program
    
    {
        static void Main()
        {
            try
            {
                int num1 = 10;
                int num2 = 0;
                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
        }
    }

}

