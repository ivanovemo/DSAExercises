using DSAExercises.Nodes;

namespace DSAExercises.Queues;

class QueuesLinked
{
    Node front;
    Node rear;
    int size;

    public QueuesLinked()
    {
        rear = null!;
        front = null!;
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

    public void Enqueue(int e)
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
        size++;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }

        int e = front.element;
        front = front.next!;
        size--;
        return e;
    }

    public void Display()
    {
        Node p = front;
        while (p != null)
        {
            Console.Write(p.element);
            if (p.next != null)
            {
                Console.Write("->");
            }
            p = p.next!;
        }

        Console.WriteLine();
    }
}
