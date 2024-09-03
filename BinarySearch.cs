namespace DSAExercises
{
    public class BinarySearch
    {
        public decimal binarySearch(int[] A, int n, int key)
        {
            int left = 0;
            int right = n - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (key == A[mid])
                {
                    return mid;
                }
                else if (key < A[mid])
                {
                    right = mid - 1;
                }
                else if (key > A[mid])
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        public int binarySearchRecursive(int[] A, int key, int left, int right) //left and right are indexes
        {
            if (left > right)
            {
                return -1;
            }
            else
            {
                int mid = (left + right) / 2; //mid = index

                if (key == A[mid])
                {
                    return mid;
                }
                else if (key < A[mid])
                {
                    return binarySearchRecursive(A, key, left, mid - 1);
                }
                else if (key > A[mid])
                {
                    return binarySearchRecursive(A, key, mid + 1, right);
                }
            }

            return -1;
        }
    }
}

