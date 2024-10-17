using System;
using System.Collections.Generic;
namespace practice_for_M1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Names = new Stack<string>();
            Names.Push("Aishwarya");
            Names.Push("Nammy");
            Names.Push("Ananya");
            Names.Push("Ipsu");
            Names.Push("Seli");
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }

         
        }
    }
}
