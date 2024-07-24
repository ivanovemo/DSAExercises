namespace LearnDSAlgorithms
{
    public class Node
    {
        public int element;
        public Node next;

        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }

    class LinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void addLast(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                head = newest;
            }
            else
            {
                tail.next = newest;
            }

            tail = newest;
            size = size + 1;
        }

        public void display()
        {
            Node p = head;
            while(p != null)
            {
                Console.Write(p.element + " -> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                tail = newest;
            }
            else
            {
                newest.next = head;
            }

            head = newest;
            size += 1;
        }

        public void addAny(int e, int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while(i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }

            newest.next = p.next;
            p.next = newest;
            size = size + 1;
        }
    }
}