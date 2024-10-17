namespace ques_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Names = new List<string>();
            Names.Add("Aishwarya");
            Names.Add("Nammy");
            Names.Add("Ananya");
            Names.Add("Ipsu");
            Names.Add("Seli");
            Names.Add("Ipsu");
            Names.Add("Seli");
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            List<T> RemoveDuplicates<T>(List<T> list)
            {
                HashSet<T> seen = new HashSet<T>();
                List<T> result = new List<T>();

                foreach (T item in list)
                {
                    if (!seen.Contains(item))
                    {
                        seen.Add(item);
                        result.Add(item);
                    }
                }
                return result;
                List<string> noDuplicates = RemoveDuplicates(string);

                foreach (string number in noDuplicates)
                {
                    Console.Write(number + " ");
                }
            }
        }
    } 
}
