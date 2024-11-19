using DSAExercises.Nodes;

namespace DSAExercises.BinarySearchTrees;

public class BinarySearchTree
{
    public BinarySearchTreeNode root;

    public BinarySearchTree()
    {
        root = null!;
    }

    public bool Delete(int e)
    {
        BinarySearchTreeNode p = root;
        BinarySearchTreeNode pp = null!;

        while (p != null && p.element != e)
        {
            pp = p;
            if (e < p.element)
            {
                p = p.left;
            }
            else
            {
                p = p.right;
            }
        }

        if (p == null)
        {
            return false;
        }
        if (p.left != null && p.right != null)
        {
            BinarySearchTreeNode s = p.left;
            BinarySearchTreeNode ps = p;

            while (s.right != null)
            {
                ps = s;
                s = s.right;
            }
            p.element = s.element;
            p = s;
            pp = ps;
        }
        BinarySearchTreeNode c = null!;

        if (p.left != null)
        {
            c = p.left;
        }
        else
        {
            c = p.right!;
        }
        if (p == root)
        {
            root = null!;
        }
        else
        {
            if (p == pp.left)
            {
                pp.left = c;
            }
            else
            {
                pp.right = c;
            }
        }

        return true;
    }

    public bool RecursiveSearch(BinarySearchTreeNode tempRoot, int key)
    {
        if (tempRoot != null)
        {
            if (key == tempRoot.element)
            {
                return true;
            }
            else if (key < tempRoot.element)
            {
                return RecursiveSearch(tempRoot.left, key);
            }
            else if (key > tempRoot.element)
            {
                return RecursiveSearch(tempRoot.right, key);
            }
        }

        return false;
    }

    public bool Search(int key)
    {
        BinarySearchTreeNode tempRoot = root;
        while (tempRoot != null)
        {
            if (key == tempRoot.element)
            {
                return true;
            }
            else if (key < tempRoot.element)
            {
                tempRoot = tempRoot.left;
            }
            else if (key > tempRoot.element)
            {
                tempRoot = tempRoot.right;
            }
        }

        return false;
    }

    public void Levelorder()
    {
        BinarySearchTreeQueues q = new BinarySearchTreeQueues();
        BinarySearchTreeNode t = root;
        Console.Write(t.element + " ");
        q.Enqueue(t);

        while (!q.IsEmpty())
        {
            t = (BinarySearchTreeNode)q.Dequeue();
            if (t.left != null)
            {
                Console.Write(t.left.element + " ");
                q.Enqueue(t.left);
            }
            if (t.right != null)
            {
                Console.Write(t.right.element + " ");
                q.Enqueue(t.right);
            }
        }
    }

    public void Preorder(BinarySearchTreeNode troot)
    {
        if (troot != null)
        {
            Console.Write(troot.element + " ");
            Preorder(troot.left);
            Preorder(troot.right);
        }
    }

    public void Postorder(BinarySearchTreeNode troot)
    {
        if (troot != null)
        {
            Preorder(troot.left);
            Preorder(troot.right);
            Console.Write(troot.element + " ");
        }
    }

    public BinarySearchTreeNode RecursiveInsert(BinarySearchTreeNode tempRoot, int e)
    {
        if (tempRoot != null)
        {
            if (e < tempRoot.element)
            {
                tempRoot.left = RecursiveInsert(tempRoot.left, e);
            }
            else if (e > tempRoot.element)
            {
                tempRoot.right = RecursiveInsert(tempRoot.right, e);
            }
        }
        else
        {
            BinarySearchTreeNode n = new BinarySearchTreeNode(e, null!, null!);
            tempRoot = n;
        }

        return tempRoot;
    }

    public void Insert(BinarySearchTreeNode tempRoot, int e)
    {
        BinarySearchTreeNode temp = null!;
        while (tempRoot != null)
        {
            temp = tempRoot;
            if (e == tempRoot.element)
            {
                return;
            }
            else if (e < tempRoot.element)
            {
                tempRoot = tempRoot.left;
            }
            else if (e > tempRoot.element)
            {
                tempRoot = tempRoot.right;
            }
        }
        BinarySearchTreeNode n = new BinarySearchTreeNode(e, null!, null!);
        if (root != null)
        {
            if (e < temp!.element)
            {
                temp.left = n;
            }
            else
            {
                temp.right = n;
            }
        }
        else
        {
            root = n;
        }
    }


    public void Inorder(BinarySearchTreeNode temproot)
    {
        if (temproot != null)
        {
            Inorder(temproot.left);
            Console.Write(temproot.element + " ");
            Inorder(temproot.right);
        }
    }

    public int Count(BinarySearchTreeNode temproot)
    {
        if (temproot != null)
        {
            int x = Count(temproot.left);
            int y = Count(temproot.right);
            return x + y + 1;
        }

        return 0;
    }

    public int FindHeight(BinarySearchTreeNode temproot)
    {
        if (temproot != null)
        {
            int x = FindHeight(temproot.left);
            int y = FindHeight(temproot.right);
            if (x > y)
            {
                return x + 1;
            }
            else
            {
                return y + 1;
            }
        }

        return 0;
    }
}