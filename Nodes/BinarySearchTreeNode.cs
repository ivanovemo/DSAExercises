namespace DSAExercises.Nodes;

public class BinarySearchTreeNode
{
    public int element;
    public BinarySearchTreeNode left;
    public BinarySearchTreeNode right;
    
    public BinarySearchTreeNode(int e, BinarySearchTreeNode l, BinarySearchTreeNode r)
    {
        element = e;
        left = l;
        right = r;
    }
}

public class QNode
{
    public Object element;
    public QNode next;

    public QNode(Object e) {
        element = e;
        next = null!;
    }
}

public class BinarySearchTreeQueues
{
    QNode front;
    QNode rear;
    int size;

    public BinarySearchTreeQueues()
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

    public void Enqueue(Object e)
    {
        QNode newest = new QNode(e);

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

    public Object Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return -1;
        }

        Object e = front.element;
        front = front.next;
        size--;
        return e;
    }

    public void Display()
    {
        QNode p = front;
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