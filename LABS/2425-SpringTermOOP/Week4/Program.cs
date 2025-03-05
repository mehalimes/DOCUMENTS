using Week4.Classes;

namespace Week4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);

            n1.next = n2;
            n2.next = n3;

            n3.prev = n2;
            n2.prev = n1;


            Console.WriteLine("ALL NODES");
            Node.PrintAll(n1);

            Console.WriteLine("\nADD 0 TO BEGINNING");
            Node newHead = new Node(0);
            Node.AddFirst(newHead, n1);
            Node.PrintAll(newHead);

            Console.WriteLine("\nADD 4 TO TAIL");
            Node newTail = new Node(4);
            Node.AddLast(newHead, newTail);
            Node.PrintAll(newHead);

            Console.WriteLine("\nINSERT 10 AFTER 2");
            Node add = new Node(10);
            Node.AddAfter(newHead, n2, add);
            Node.PrintAll(newHead);

            Console.WriteLine("\nINSERT 20 BEFORE 2");
            Node add2 = new Node(20);
            Node.AddBefore(newHead,n2,add2);
            Node.PrintAll(newHead);

        }
    }
}
