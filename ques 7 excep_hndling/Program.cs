using System;
namespace ques_7_excep_hndling
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                string str = null;
                Console.WriteLine(str.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: Tried to access a member of a null object.");
            }
        }
    }

}

