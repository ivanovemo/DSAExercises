using System;
namespace DSAExercises
{
    public class Recursion
    {
        public void calculateIterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

        public void calculateRecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calculateRecursive(n - 1);
            }
        }
    }
}

