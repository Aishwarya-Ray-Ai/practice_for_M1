using System;
using System.IO;
namespace ques_9_exception_handling
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                string filePath = "Aishwarya.java";
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: The file '{ex.FileName}' was not found.");
            }
        }
    }

}
}
