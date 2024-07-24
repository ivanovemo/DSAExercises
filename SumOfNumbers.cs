using System;
namespace DSAExercises
{
	public class SumOfNumbers
    {
        public int sumRecursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return sumRecursion(n - 1) + n;
        }

        public int sumIteration(int n)
        {
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                total = total + i;
                i = i + 1;
            }

            return total;
        }

        public int sumOfNNumbers(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}