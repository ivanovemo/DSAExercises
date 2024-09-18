using System.Linq.Expressions;

namespace DSAExercises
{
    public class DoublyLinkedList
	{
        private Node head;
        private Node tail;
        private int size;

        public DoublyLinkedList()
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
            Node newest = new Node(e, null, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.prev = tail;
                tail = newest;
            }
            size += 1;
        }

        public void display()
        {
            Node p = head;
            while(p != null)
            {
                Console.Write(p.element + "->");
                p = p.next!;
            }

            Console.WriteLine();
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null, null);

            if(isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head.prev = newest;
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

            Node newest = new Node(e, null, null);
            Node p = head;
            int i = 1;

            while (i < position - 1)
            {
                p = p.next!;
                i += 1;
            }
            newest.next = p.next;
            p.next!.prev = newest;
            p.next = newest;
            newest .prev = p;
            size += 1;
        }

        public int removeFirst()
        {
            if(isEmpty())
            {
                Console.WriteLine("The list is empty!");
                return -1;
            }

            int e = head.element;
            head = head.next!;
            size -= 1;

            if(isEmpty())
            {
                tail = null!;
            }
            else
            {
                head.prev = null;
            }

            return e;
        }

        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("Doubly list is empty!");
                return -1;
            }
            int e = tail.element;
            tail = tail.prev!;
            tail.next = null;
            size -= 1;

            return e;
        }
    }
}
