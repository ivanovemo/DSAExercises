namespace DSAExercises.Stacks;

public class StacksArray
{
    int[] data;
    int top;

    public StacksArray(int n)
    {
        data = new int[n];
        top = 0;
    }

    public int Length()
    {
        return top;
    }

    public bool IsEmpty()
    {
        return top == 0;
    }

    public bool IsFull()
    {
        return top == data.Length;
    }

    public void Push(int e)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full/overflow!");
            return;
        }
        else
        {
            data[top] = e;
            top += 1;
        }
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty/underflow!");
            return -1;
        }
        int e = data[top - 1];
        top -= 1;
        return e;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }

        return data[top - 1];
    }

    public void Display()
    {
        for (int i = 0; i < top; i++)
        {
            Console.Write(data[i]);
            if (i < top - 1)
            {
                Console.Write("-");
            }
        }
        Console.WriteLine();
    }
}