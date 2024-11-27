namespace DSAExercises.Hashes;

class HashLinearProbe
{
    int hashTableSize;
    int[] hashTable;

    public HashLinearProbe()
    {
        hashTableSize = 10;
        hashTable = new int[hashTableSize];
    }

    public int HashCode(int key)
    {
        return key % hashTableSize;
    }

    public int LProbe(int element)
    {
        int i = HashCode(element);
        int j = 0;
        while (hashTable[(i + j) % hashTableSize] != 0)
        {
            j += 1;
        }
        return (i + j) % hashTableSize;
    }

    public void Insert(int element)
    {
        int i = HashCode(element);
        if (hashTable[i] == 0)
        {
            hashTable[i] = element;
        }
        else
        {
            i = LProbe(element);
            hashTable[i] = element;
        }
    }

    public bool Search(int key)
    {
        int i = HashCode(key);
        int j = 0;
        while (hashTable[(i + j) % hashTableSize] != key)
        {
            if (hashTable[(i + j) % hashTableSize] == 0)
            {
                return false;
            }
            j += 1;
        }
        return true;
    }

    public void Display()
    {
        for (int i = 0; i < hashTableSize; i++)
        {
            Console.Write(hashTable[i] + " ");
        }
        Console.WriteLine();
    }
}