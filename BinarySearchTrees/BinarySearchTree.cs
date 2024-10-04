using DSAExercises.Nodes;

namespace DSAExercises.BinarySearchTrees;

public class BinarySearchTree
{
    public BinarySearchTreeNode root;

    public BinarySearchTree()
    {
        root = null!;
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

        while(!q.IsEmpty())
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
}