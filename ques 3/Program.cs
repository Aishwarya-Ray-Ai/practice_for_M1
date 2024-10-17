namespace ques_3
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
        public void AddSorted(int data)
        {
            Node newNode = new Node(data);

            if (head == null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null && current.next.data < newNode.data)
                {
                    current = current.next;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
        }
        public static LinkedList Merge(LinkedList list1, LinkedList list2)
        {
            Node dummy = new Node(0); 
            Node tail = dummy;
            Node a = list1.head;
            Node b = list2.head;

            while (a != null && b != null)
            {
                if (a.data <= b.data)
                {
                    tail.next = a;
                    a = a.next;
                }
                else
                {
                    tail.next = b;
                    b = b.next;
                }
                tail = tail.next;
            }

            // Attach the remaining nodes, if any
            if (a != null) tail.next = a;
            if (b != null) tail.next = b;

            LinkedList mergedList = new LinkedList();
            mergedList.head = dummy.next;  // Skip the dummy node
            return mergedList;
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
    class Test
    {
        static void Main()
        {
            LinkedList list1 = new LinkedList();
            list1.AddSorted(1);
            list1.AddSorted(3);
            list1.AddSorted(5);

            LinkedList list2 = new LinkedList();
            list2.AddSorted(2);
            list2.AddSorted(4);
            list2.AddSorted(6);

            Console.WriteLine("List 1:");
            list1.PrintList();  

            Console.WriteLine("List 2:");
            list2.PrintList();  

            LinkedList mergedList = LinkedList.Merge(list1, list2);

            Console.WriteLine("Merged List:");
            mergedList.PrintList();  
        }
    }

}
}
