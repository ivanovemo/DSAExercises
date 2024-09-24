namespace DSAExercises
{
    class DeQueLinked
    {
        private Node front;
        private Node rear;
        private int size;

        public DeQueLinked()
        {
            front = null!;
            rear = null!;
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

        public void AddLast(int e)
        {
            Node newest = new Node(e, null!);
            if (IsEmpty())
            {
                front = newest;
            }
            else
            {
                rear.next = newest;
            }

            rear = newest;
            size = size + 1;
        }

        public void Display()
        {
            Node p = front;
            while (p != null)
            {
                Console.Write(p.element);
                if (p.next != null)
                {
                    Console.Write(" -> ");
                }
                p = p.next;
            }
            Console.WriteLine();
        }

        public void AddFirst(int e)
        {
            Node newest = new Node(e, null!);
            if (IsEmpty())
            {
                rear = newest;
            }
            else
            {
                newest.next = front;
            }

            front = newest;
            size += 1;
        }

        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return -1;
            }
            else
            {
                int e = front.element;
                front = front.next;
                size = size - 1;
                if (IsEmpty())
                {
                    rear = null!;
                }

                return e;
            }
        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return -1;
            }

            Node p = front;
            int i = 1;
            while (i < size - 1)
            {
                p = p.next;
                i += 1;
            }
            rear = p;
            p = p.next;
            int e = p.element;
            rear.next = null!;
            size -= 1;
            return e;
        }        

        public int Search(int key)
        {
            Node p = front;
            int index = 0;
            while(p != null)
            {
                if (p.element == key)
                {
                    return index;
                }

                p = p.next;
                index++;
            }
            Console.WriteLine("The element wasn't found!");
            return -1;
        }

        public int First()
        {
            if (IsEmpty())
            {
                Console.WriteLine("DeQueue is empty!");
                return -1;
            }

            return front.element;
        }

        public int Last()
        {
            if (IsEmpty())
            {
                Console.WriteLine("DeQueue is empty!");
                return -1;
            }

            return rear.element;
        }
    }
}