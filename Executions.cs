using DSAExercises.BinarySearchTrees;
using DSAExercises.CircularLinkedLists;
using DSAExercises.DoublyLinkedLists;
using DSAExercises.Hashes;
using DSAExercises.Heaps;
using DSAExercises.LinkedLists;
using DSAExercises.Queues;
using DSAExercises.Recursive;
using DSAExercises.SearchingAlgorithms;
using DSAExercises.SortingAlgorithms;
using DSAExercises.Stacks;

namespace DSAExercises;

class Executions
{
    static void Main(string[] args)
    {
        Recursion rec = new Recursion();
        rec.calculateIterative(4);
        rec.calculateRecursive(4);

        Console.WriteLine();

        SumOfNumbers sum = new SumOfNumbers();
        Console.WriteLine("Sum: " + sum.sumOfNNumbers(5));
        Console.WriteLine("Sum: " + sum.sumIteration(5));
        Console.WriteLine("Sum: " + sum.sumRecursion(5));

        Console.WriteLine();

        Factorial fact = new Factorial();
        Console.WriteLine("Factorial: " + fact.factorialIterative(5));
        Console.WriteLine("Factorial: " + fact.factorialRecursive(5));

        Console.WriteLine();

        Search search = new Search();
        int[] A = { 84, 21, 47, 96, 15 };
        Console.WriteLine("Result: " + search.linearSearch(A, 5, 96));
        Console.WriteLine("Result: " + search.linearSearch(A, 5, 100));

        Console.WriteLine();

        BinarySearch bs = new BinarySearch();
        int[] B = { 15, 21, 47, 84, 96 };
        Console.WriteLine("Result: " + bs.binarySearch(B, 5, 96));
        Console.WriteLine("Result: " + bs.binarySearch(B, 5, 100));

        Console.WriteLine("Result: " + bs.binarySearchRecursive(B, 96, 0, 4));
        Console.WriteLine("Result: " + bs.binarySearchRecursive(B, 21, 0, 4));
        Console.WriteLine("Result: " + bs.binarySearchRecursive(B, 100, 0, 4));

        Console.WriteLine();

        Sort s = new Sort();
        int[] C = { 3, 5, 8, 9, 6, 2 };
        Console.WriteLine("Original array: ");
        s.Display(C, 6);
        s.InsertionSort(C, 6);

        Console.WriteLine("Sorted array: ");
        s.Display(C, 6);

        Console.WriteLine("Original array: ");
        s.Display(C, 6);
        s.BubbleSort(C, 6);

        Console.WriteLine("Sorted array: ");
        s.Display(C, 6);

        Console.WriteLine("Original array: ");
        s.Display(C, 6);
        s.BubbleSort(C, 6);

        Console.WriteLine("Sorted array: ");
        s.Display(C, 6);

        Console.WriteLine("Original array:");
        s.Display(C, 6);
        s.MergeSort(C, 0, 5);

        Console.WriteLine("Sorted array:");
        s.Display(C, 6);

        Console.WriteLine("Original array: ");
        s.Display(C, 6);
        s.QuickSort(C, 0, C.Length - 1);

        Console.WriteLine("Sorted array: ");
        s.Display(C, 6);

        LinkedList l = new LinkedList();
        l.InsertSorted(7);
        l.InsertSorted(4);
        l.InsertSorted(12);
        l.InsertSorted(8);
        l.InsertSorted(3);
        l.Display();

        Console.WriteLine();

        CircularLinkedList cl = new CircularLinkedList();
        cl.addLast(7);
        cl.addLast(4);
        cl.addLast(12);
        cl.addLast(8);
        cl.addLast(3);
        cl.display();
        Console.WriteLine("Size: " + cl.length());
        cl.addAny(20, 3);
        cl.display();
        Console.WriteLine("Size: " + cl.length());
        cl.addAny(30, 5);
        cl.display();
        Console.WriteLine("Size: " + cl.length());
        int firstRemovedElement = cl.removeFirst();
        cl.display();
        Console.WriteLine("Removed element: " + firstRemovedElement);
        Console.WriteLine("Size: " + cl.length());
        int lastRemovedElement = cl.removeLast();
        cl.display();
        Console.WriteLine("Removed element: " + lastRemovedElement);
        Console.WriteLine("Size: " + cl.length());
        int removedElement = cl.removeAny(3);
        cl.display();
        Console.WriteLine("Removed element: " + removedElement);
        Console.WriteLine("Size: " + cl.length());

        Console.WriteLine();

        DoublyLinkedList dls = new DoublyLinkedList();
        dls.addLast(7);
        dls.addLast(4);
        dls.addLast(12);
        dls.addLast(8);
        dls.addLast(3);
        dls.display();
        Console.WriteLine("Size: " + dls.length());
        int removedEl = dls.removeFirst();
        Console.WriteLine("Removed element:" + removedEl);
        dls.display();
        Console.WriteLine("Size: " + dls.length());

        Console.WriteLine();

        Console.WriteLine("Size: " + dls.length());
        int lastRemovedEl = dls.removeLast();
        Console.WriteLine("Removed element:" + lastRemovedEl);
        dls.display();
        Console.WriteLine("Size: " + dls.length());

        Console.WriteLine();

        Console.WriteLine("Size: " + dls.length());
        int removedAnyElement = dls.RemoveAny(3);
        Console.WriteLine("Removed element:" + removedAnyElement);
        dls.display();
        Console.WriteLine("Size: " + dls.length());

        Console.WriteLine();

        StacksArray sa = new StacksArray(10);
        sa.Push(5);
        sa.Push(3);
        sa.Display();
        Console.WriteLine("Size: " + sa.Length());
        Console.WriteLine("Element popped: " + sa.Pop());
        Console.WriteLine("Is empty: " + sa.IsEmpty());
        Console.WriteLine("Element popped: " + sa.Pop());
        Console.WriteLine("Is empty: " + sa.IsEmpty());
        sa.Push(7);
        sa.Push(9);
        sa.Display();
        Console.WriteLine("Top element: " + sa.Peek());
        sa.Display();

        Console.WriteLine();

        StacksLinked sl = new StacksLinked();
        sl.Push(5);
        sl.Push(3);
        sl.Display();
        Console.WriteLine("Size: " + sl.Length());
        Console.WriteLine("Element removed: " + sl.Pop());
        Console.WriteLine("Is empty: " + sl.IsEmpty());
        Console.WriteLine("Element removed: " + sl.Pop());
        Console.WriteLine("Is empty: " + sl.IsEmpty());
        sl.Push(7);
        sl.Push(9);
        sl.Display();

        Console.WriteLine();

        QueuesArray qa = new QueuesArray(10);
        qa.Enqueue(5);
        qa.Enqueue(3);
        qa.Display();
        Console.WriteLine("Size: " + qa.Length());
        Console.WriteLine("Element removed: " + qa.Dequeue());
        Console.WriteLine("Is empty: " + qa.IsEmpty());
        Console.WriteLine("Element removed: " + qa.Dequeue());
        Console.WriteLine("Is empty: " + qa.IsEmpty());
        qa.Enqueue(7);
        qa.Enqueue(9);
        qa.Enqueue(4);
        qa.Display();
        Console.WriteLine("Size: " + qa.Length());

        Console.WriteLine();

        QueuesLinked ql = new QueuesLinked();
        ql.Enqueue(5);
        ql.Enqueue(3);
        ql.Display();
        Console.WriteLine("Size: " + ql.Length());
        Console.WriteLine("Element removed: " + ql.Dequeue());
        Console.WriteLine("Is empty: " + ql.IsEmpty());
        Console.WriteLine("Element removed: " + ql.Dequeue());
        Console.WriteLine("Is empty: " + ql.IsEmpty());

        Console.WriteLine();

        DeQueLinked dql = new DeQueLinked();
        dql.AddFirst(5);
        dql.AddFirst(3);
        dql.AddLast(7);
        dql.AddLast(12);
        dql.Display();
        Console.WriteLine("Size: " + dql.Length());
        Console.WriteLine("Front element removed: " + dql.RemoveFirst());
        Console.WriteLine("Rear element removed: " + dql.RemoveLast());
        dql.Display();
        Console.WriteLine("First element: " + dql.First());
        Console.WriteLine("Last element: " + dql.Last());

        Console.WriteLine();

        BinarySearchTree bstB = new BinarySearchTree();
        bstB.Insert(bstB.root, 50);
        bstB.Insert(bstB.root, 30);
        bstB.Insert(bstB.root, 80);
        bstB.Insert(bstB.root, 10);
        bstB.Insert(bstB.root, 40);
        bstB.Insert(bstB.root, 60);
        bstB.Insert(bstB.root, 90);
        Console.WriteLine("Inorder Traversal");
        bstB.Inorder(bstB.root);

        Console.WriteLine();

        BinarySearchTree bstC = new BinarySearchTree();
        bstC.root = bstC.RecursiveInsert(bstC.root, 50);
        bstC.RecursiveInsert(bstC.root, 30);
        bstC.RecursiveInsert(bstC.root, 80);
        bstC.RecursiveInsert(bstC.root, 10);
        bstC.RecursiveInsert(bstC.root, 40);
        bstC.RecursiveInsert(bstC.root, 60);
        bstC.RecursiveInsert(bstC.root, 90);
        Console.WriteLine("Inorder Traversal");
        bstC.Inorder(bstC.root);
        Console.WriteLine();
        // bstC.Delete(50);
        Console.WriteLine("Inorder Traversal after delete");
        bstC.Inorder(bstC.root);
        Console.WriteLine();
        Console.WriteLine("Preorder Traversal");
        bstC.Preorder(bstC.root);
        Console.WriteLine();
        Console.WriteLine("Postorder Traversal");
        bstC.Postorder(bstC.root);
        Console.WriteLine();
        Console.WriteLine("Level order Traversal");
        bstC.Levelorder();
        Console.WriteLine();
        Console.WriteLine("Search result: " + bstC.Search(60));
        Console.WriteLine("Recursive search result: " + bstC.RecursiveSearch(bstC.root, 60));
        Console.WriteLine("Number of node: " + bstC.Count(bstC.root));
        Console.WriteLine("Binary tree height: " + (bstC.FindHeight(bstC.root) -1));

        Heap heap = new Heap();
        heap.Insert(25);
        heap.Insert(14);
        heap.Insert(2);
        heap.Insert(20);
        heap.Insert(10);
        heap.Insert(40);
        heap.Display();
        int element = heap.DeleteMax();
        Console.WriteLine("Element deleted: " + element);

        int[] heapArray = { 63, 25, 835, 947, 651, 28 };
        Console.WriteLine("Original array:");
        heap.DisplayArray(heapArray, 6);
        heap.Sort(heapArray, 6);
        Console.WriteLine("Sorted array:");
        heap.DisplayArray(heapArray, 6);

        Console.WriteLine();

        HashChain hashChain = new HashChain();
        hashChain.Insert(54);
        hashChain.Insert(78);
        hashChain.Insert(64);
        hashChain.Insert(92);
        hashChain.Insert(34);
        hashChain.Insert(86);
        hashChain.Insert(28);
        hashChain.Display();
        Console.WriteLine("Element Found: " + hashChain.Search(64));
        Console.WriteLine("Element Found: " + hashChain.Search(44));

        Console.WriteLine();

        HashLinearProbe hashLinearProbe = new HashLinearProbe();
        hashLinearProbe.Insert(54);
        hashLinearProbe.Insert(78);
        hashLinearProbe.Insert(64);
        hashLinearProbe.Insert(92);
        hashLinearProbe.Insert(34);
        hashLinearProbe.Insert(86);
        hashLinearProbe.Insert(28);
        hashLinearProbe.Display();
        Console.WriteLine("Element found: " + hashLinearProbe.Search(64));
        Console.WriteLine("Element found: " + hashLinearProbe.Search(44));
    }
}