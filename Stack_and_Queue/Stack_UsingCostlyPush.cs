namespace Stack_and_Queue;

public class Stack_UsingCostlyPush
{
    private Queue<int> q1 = new();
    private Queue<int> q2 = new();

    public void Push(int val)
    {
        q2.Enqueue(val);

        while (q1.Count > 0)
        {
            // Move all elements from q1 to q2
            q2.Enqueue(q1.Dequeue());
        }

        //swap via deconstruction
        (q1, q2) = (q2, q1);
    }

    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack underflow");

        return q1.Dequeue();
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return q1.Peek();
    }
    
    public void PrintStack()
    {
        Console.WriteLine("Stack contents (top to bottom):");
        foreach (var item in q1)
            Console.WriteLine(item);
    }

    public bool IsEmpty() => q1.Count == 0;
}