namespace DSAExercises
{
    public class CircularLinkedList
	{
        private Node head;
        private Node tail;
        private int size;

        public CircularLinkedList()
        {
            head = null!;
            tail = null!;
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
            Node newest = new Node(e, null!);
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
            Node newest = new Node(e, null!);
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

        public void addAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid position!");
                return;
            }

            Node newest = new Node(e, null!);
            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i += 1;
            }

            newest.next = p.next;
            p.next = newest;
            size += 1;
        }

        public int removeFirst() {
            if (isEmpty())
            {
                Console.WriteLine("Circular list is empty!");
                return -1;
            }

            int e = head.element;
            tail.next = head.next;
            head = head.next;
            size -= 1;
            if (isEmpty())
            {
                head = null!;
                tail = null!;
            }

            return e;
        }

        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("Circular list is empty!");
                return -1;
            }

            Node p = head;
            int i = 1;
            while (i < length() - 1)
            {
                p = p.next;
                i += 1;
            }

            tail = p;
            p = p.next;
            tail.next = head;
            int e = p.element;
            size -= 1;
            return e;
        }

        public int removeAny(int position)
        {
            if (position <= 0 || position >= size - 1)
            {
                Console.WriteLine("Invalid position!");
                return -1;
            }

            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i += 1;
            }

            int e = p.next.element;
            p.next = p.next.next;
            size -= 1;
            return e;
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