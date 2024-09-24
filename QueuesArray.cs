using DSAExercises;

namespace DSAExercises
{
    public class QueuesArray
    {
        int[] data;
        int front;
        int rear;
        int size;

        public QueuesArray(int n)
        {
            data = new int[n];
            front = 0;
            rear = 0;
            size = 0;
        }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return size == data.Length;
        }

        public void Enqueue(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full!");
                return;
            }
            else
            {
                data[rear] = e;
                rear ++;
                size ++;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            
            int e = data[front];
            front ++;
            size --;
            return e;
        }

        public void Display()
        {
            for (int i = front; i < rear; i++)
            {
                Console.Write(data[i] + "-");
            }

            Console.WriteLine();
        }
    }
}