using System;
namespace ques_8_except_handling
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Index is out of range.");
            }
        }
    }

}

