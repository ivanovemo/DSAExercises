﻿using LearnDSAlgorithms;

namespace DSAExercises;

class Executions
{
    static void Main(string[] args)
    {
        // Recursion rec = new Recursion();
        //rec.calculateIterative(4);
        //rec.calculateRecursive(4);

        //SumOfNumbers sum = new SumOfNumbers();
        //Console.WriteLine("Sum: " + sum.sumOfNNumbers(5));
        //Console.WriteLine("Sum: " + sum.sumIteration(5));
        //Console.WriteLine("Sum: " + sum.sumRecursion(5));

        //Factorial fact = new Factorial();
        //Console.WriteLine("Factorial: " + fact.factorialIterative(5));
        //Console.WriteLine("Factorial: " + fact.factorialRecursive(5));

        //Search search = new Search();
        //int[] A = { 84, 21, 47, 96, 15 };
        //Console.WriteLine("Result: " + search.linearSearch(A, 5, 96));
        //Console.WriteLine("Result: " + search.linearSearch(A, 5, 100));

        //BinarySearch bs = new BinarySearch();
        //int[] B = { 15, 21, 47, 84, 96 };
        //Console.WriteLine("Result: " + bs.binarySearch(B, 5, 96));
        //Console.WriteLine("Result: " + bs.binarySearch(B, 5, 100));

        //Console.WriteLine("Result: " + bs.binarySearchRecursive(B, 96, 0, 4));
        //Console.WriteLine("Result: " + bs.binarySearchRecursive(B, 21, 0, 4));
        //Console.WriteLine("Result: " + bs.binarySearchRecursive(B, 100, 0, 4));

        //Sort s = new Sort();
        //int[] C = { 3, 5, 8, 9, 6, 2 };
        //Console.WriteLine("Original array: ");
        //s.display(C, 6);
        //s.insertionSort(C, 6);

        //Console.WriteLine("Sorted array: ");
        //s.display(C, 6);

        //Console.WriteLine("Original array: ");
        //s.display(C, 6);
        //s.bubbleSort(C, 6);

        //Console.WriteLine("Sorted array: ");
        //s.display(C, 6);

        //Console.WriteLine("Original array: ");
        //s.display(C, 6);
        //s.bubbleSort(C, 6);

        //Console.WriteLine("Sorted array: ");
        //s.display(C, 6);

        //Console.WriteLine("Original array:");
        //s.display(C, 6);
        //s.mergeSort(C, 0, 5);

        //Console.WriteLine("Sorted array:");
        //s.display(C, 6);

        //Console.WriteLine("Original array: ");
        //s.display(C, 6);
        //s.quickSort(C, 0, C.Length - 1);

        //Console.WriteLine("Sorted array: ");
        //s.display(C, 6);

        //LinkedList l = new LinkedList();
        //l.insertSorted(7);
        //l.insertSorted(4);
        //l.insertSorted(12);
        //l.insertSorted(8);
        //l.insertSorted(3);
        //l.display();

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
        int removedElement = cl.removeFirst();
        cl.display();
        Console.WriteLine("Size: " + cl.length());
        Console.WriteLine("Removed element: " + removedElement);
    }
}