using System;
namespace ques_4
{
    internal class Program
    {
public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    public class LinkedList
    {
        public Node head;

        // Method to add elements to the end of the list
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }

        // Method to find the middle element of the list
        public int FindMiddle()
        {
            Node slow = head;
            Node fast = head;

            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow.data;  // Slow will be at the middle
        }

        // Method to print the linked list
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

    class  Test
    {
        static void Main()
        {
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            Console.WriteLine("List:");
            list.PrintList();  // Outputs: 1 2 3 4 5

            int middle = list.FindMiddle();
            Console.WriteLine("Middle Element: " + middle);  // Outputs: 3
        }
    }

}
}
