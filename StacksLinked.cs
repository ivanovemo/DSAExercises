namespace DSAExercises
{
    class StacksLinked
    {
        Node top;
        int size;

        public StacksLinked()
        {
            top = null;
            size = 0;
        }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Push(int e)
        {
            Node newest = new Node(e, null);

            if (IsEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }

            size ++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }

            int e = top.element;
            top = top.next;
            size --;

            return e;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }

            return top.element;
        }

        public void Display()
        {
            Node p = top;
            while (p != null)
            {
                Console.Write(p.element);
                p = p.next;
                if (p != null)
                {
                    Console.Write(" -> ");
                }
            }

            Console.WriteLine();
        }
    }
}