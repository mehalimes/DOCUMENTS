namespace Week4.Classes
{
    public class Node
    {
        public Node prev;
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            prev = null;
            next = null;
        }

        public static void AddFirst(Node newHead, Node previousHead)
        {
            previousHead.prev = newHead;
            newHead.next = previousHead;
        }

        public static void AddLast(Node head, Node newTail)
        {
            while(head.next != null)
            {
                head = head.next;
            }
            head.next = newTail;
            newTail.prev = head;
        }

        public static void AddAfter(Node head, Node after, Node newNode)
        {
            while(head.data != after.data)
            {
                head = head.next;
            }

            Node afterNext = head.next;
            afterNext.prev = null;
            head.next = null;
            head.next = newNode;
            afterNext.prev = newNode;
            newNode.prev = head;
            newNode.next = afterNext;
        }

        public static void AddBefore(Node head, Node before, Node newNode)
        {
            while(head.data != before.data)
            {
                head = head.next;
            }
            Node beforePrev = head.prev;
            beforePrev.next = null;
            head.prev = null;
            beforePrev.next = newNode;
            head.prev = newNode;
            newNode.next = head;
            newNode.prev = beforePrev;
        }
        public static void PrintAll(Node head)
        {
            while(head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }
    }
}
