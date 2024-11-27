using DSAExercises.LinkedLists;

namespace DSAExercises.Hashes;

class HashChain {
    int hashTableSize;
    LinkedList[] hashTable;

    public HashChain()
    {
        hashTableSize = 10;
        hashTable = new LinkedList[hashTableSize];
        for (int i = 0; i < hashTableSize; i++)
        {
            hashTable[i] = new LinkedList();
        }
    }

    public int HashCode(int key)
    {
        return key % hashTableSize;
    }

    public void Insert(int element)
    {
        int i = HashCode(element);
        hashTable[i].InsertSorted(element);
    }

    public bool Search(int key)
    {
        int i = HashCode(key);
        return hashTable[i].Search(key) != -1;
    }

    public void Display()
    {
        for (int i = 0; i < hashTableSize; i++)
        {
            Console.Write("[" + i + "]");
            hashTable[i].Display();
        }
        Console.WriteLine();
    }
}