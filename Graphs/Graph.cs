using DSAExercises.Queues;

namespace DSAExercises.Graphs;

class Graph {
    int vertices;
    int[,] adjMat;
    public Graph(int n)
    {
        vertices = n;
        adjMat = new int[n, n];
    }

    public void InsertEdge(int u, int v, int x)
    {
        adjMat[u, v] = x;
    }

    public void RemoveEdge(int u, int v)
    {
        adjMat[u, v] = 0;
    }

    public bool ExistEdge(int u, int v)
    {
        return adjMat[u, v] != 0;
    }

    public int VertexCount()
    {
        return vertices;
    }

    public int EdgeCount()
    {
        int count = 0;
        for (int i = 0; i < vertices; i++)
        {
            for (int j = 0; j < vertices; j++)
            {
                if (adjMat[i,  j] !=  0)
                {
                    count ++;
                }
            }
        }
        
        return count;
    }

    public void Edges()
    {
        Console.WriteLine("Edges: ");
        for (int i = 0; i < vertices; i++)
        {
            for (int j = 0; j < vertices; j++)
            {
                if (adjMat[i, j] != 0)
                {
                    Console.WriteLine(i + "--" + j);
                }
            }
        }
    }

    public int OutDegree(int v)
    {
        int count = 0;
        for (int j = 0; j < vertices; j++)
        {
            if (adjMat[v, j] != 0)
            {
                count++;
            }
        }

        return count;
    }

    public int InDegree(int v)
    {
        int count = 0;
        for (int i = 0; i < vertices; i++)
        {
            if (adjMat[i, v] != 0)
            {
                count++;
            }
        }

        return count;
    }

    public void Display()
    {
        for (int i = 0; i < vertices; i++)
        {
            for (int j = 0; j < vertices; j++)
            {
                Console.Write(adjMat[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    public void BFS(int s)
    {
        int i = s;
        QueuesLinked ql = new QueuesLinked();
        int[] visited = new int[vertices];
        Console.Write(i + " ");
        visited[i] = 1;
        ql.Enqueue(i);
        while (!ql.IsEmpty())
        {
            i = ql.Dequeue();
            for (int j = 0; j < vertices; j++)
            {
                if (adjMat[i, j] == 1 && visited[j] == 0)
                {
                    Console.Write(j + " ");
                    visited[j] = 1;
                    ql.Enqueue(j);
                }
            }
        }
    }
}