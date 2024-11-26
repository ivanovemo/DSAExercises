namespace DSAExercises.Heaps;

class Heap {
    int[] data;
    int maxSize;
    int currentSize;

    public Heap()
    {
        maxSize = 10;
        data = new int[maxSize];
        currentSize = 0;
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = -1;
        }
    }

    public int Length()
    {
        return currentSize;
    }

    public bool IsEmpty() {
        return currentSize == 0;
    }
         
    public void Insert(int element)
    {
        if (currentSize == maxSize)
        {
            Console.WriteLine("No space in heap!");
            return;
        }
        currentSize += 1;
        int hi = currentSize;
        while (hi > 1 && element > data[hi / 2])
        {
            data[hi] = data[hi / 2];
            hi /= 2;
        }
        data[hi] = element;
    }

    public int Max()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Heap is empty!");
            return -1;
        }

        return data[1];
    }

    public void Display()
    {
        for (int i = 0; i < data.Length; i++)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }

    public int DeleteMax()
    {
        if (IsEmpty())
        {
            return -1;
        }
        int element = data[1];
        data[1] = data[currentSize];
        data[currentSize] = -1;
        currentSize -=1 ;
        int i = 1;
        int j = i * 2;
        while (j <= currentSize)
        {
            if (data[j] < data[j + 1])
            {
                j += 1;
            }
            if (data[i] < data[j])
            {
                int temp = data[i];
                data[i] = data[j];
                data[j] = temp;
                i = j;
                j = i * 2;
            }
            else 
            {
                break;
            }
        }

        return element;
    }

    public void Sort(int[] A, int n)
    {
        Heap h = new Heap();
        for (int i = 0; i < n; i++)
        {
            h.Insert(A[i]);
        }
        int k = n - 1;
        for (int i = 0; i < n; i++)
        {
            A[k] = h.DeleteMax();
            k -= 1;
        }
    }

    public void DisplayArray(int[] A, int n )
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
    }
}