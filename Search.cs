using System;
namespace DSAExercises
{
    public class Search
    {
        public int linearSearch(int[] A, int n, int key)
        {
            int index = 0;
            while (index < n)
            {
                if (A[index] == key)
                {
                    return index;
                }
                index = index + 1;
            }

            return -1;
        }
    }
}