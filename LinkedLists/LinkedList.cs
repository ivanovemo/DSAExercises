using DSAExercises.Nodes;

namespace DSAExercises.LinkedLists;

class LinkedList
{
    private Node head;
    private Node tail;
    private int size;

    public LinkedList()
    {
        head = null!;
        tail = null!;
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
            head = newest;
        }
        else
        {
            tail.next = newest;
        }

        tail = newest;
        size = size + 1;
    }

    public void Display()
    {
        Node p = head;
        while (p != null)
        {
            Console.Write(p.element + " -> ");
            p = p.next!;
        }
        Console.WriteLine();
    }

    public void AddFirst(int e)
    {
        Node newest = new Node(e, null!);
        if (IsEmpty())
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

    public void AddAny(int e, int position)
    {
        if (position <= 0 || position >= size)
        {
            Console.WriteLine("Invalid Position");
            return;
        }
        Node newest = new Node(e, null!);
        Node p = head;
        int i = 1;
        while (i < position - 1)
        {
            p = p.next!;
            i = i + 1;
        }

        newest.next = p.next;
        p.next = newest;
        size = size + 1;
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
            int e = head.element;
            head = head.next!;
            size = size - 1;
            if (IsEmpty())
            {
                tail = null!;
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

        Node p = head;
        int i = 1;
        while (i < size - 1)
        {
            p = p.next!;
            i += 1;
        }
        tail = p;
        p = p.next!;
        int e = p.element;
        tail.next = null!;
        size -= 1;
        return e;
    }
    public int RemoveAny(int position)
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
            p = p.next!;
            i++;
        }
        int e = p.next!.element;
        p.next = p.next.next;
        size -= 1;
        return e;
    }

    public int Search(int key)
    {
        Node p = head;
        int index = 0;
        while (p != null)
        {
            if (p.element == key)
            {
                return index;
            }

            p = p.next!;
            index++;
        }
        Console.WriteLine("The element wasn't found!");
        return -1;
    }

    public void InsertSorted(int e)
    {
        Node newest = new Node(e, null!);
        if (IsEmpty())
        {
            head = newest;
        }
        else
        {
            Node p = head;
            Node q = head;
            while (p != null && p.element < e)
            {
                q = p;
                p = q.next!;
            }

            if (p == head)
            {
                newest.next = head;
                head = newest;
            }
            else
            {
                newest.next = q.next;
                q.next = newest;
            }
        }

        size++;
    }
}
