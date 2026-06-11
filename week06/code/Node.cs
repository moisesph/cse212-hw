public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (Data == value) return true;

        if (Data > value && Left != null)
        {
            return Left.Contains(value);
        }

        if (Data < value && Right != null)
        {
            return Right.Contains(value);
        }

        else return false;


    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // Expected: 3
        int counter = 0;

        if (Right != null)
        {
            return 1 + Right.GetHeight();
        }
        else if (Left != null)
        {
            return 1 + Left.GetHeight();
        }
        return counter += 1; // Replace this line with the correct return statement(s)
    }
}