namespace DSAExercises
{
    public class CircularLinkedList
	{
        private Node head;
        private Node tail;
        private int size;

        public CircularLinkedList()
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
                newest.next = newest;
                head = newest;
            }
            else
            {
                newest.next = tail.next;
                tail.next = newest;
            }
            tail = newest;
            size += 1;
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                newest.next = newest;
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.next = head;
                head = newest;
            }
            size += 1;
        }

        public void display()
        {
            Node p = head;
            int i = 0;
            while(i < length())
            {
                Console.Write(p.element + "->");
                p = p.next;
                i += 1;
            }
            Console.WriteLine();
        }
    }
}