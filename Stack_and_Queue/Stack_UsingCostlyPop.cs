namespace Stack_and_Queue;

public class Stack_UsingCostlyPop
{
    private Queue<int> q1 = new Queue<int>();
    private Queue<int> q2 = new Queue<int>();

    public void Push(int x)
    {
        q1.Enqueue(x);
    }

    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack underflow");

        while (q1.Count > 1)
        {
            q2.Enqueue(q1.Dequeue());
        }

        int popped = q1.Dequeue();

        (q1, q2) = (q2, q1);

        return popped;
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        while (q1.Count > 1)
            q2.Enqueue(q1.Dequeue());

        int top = q1.Dequeue();
        q2.Enqueue(top);

        (q1, q2) = (q2, q1);
        return top;
    }
    
    public void PrintStack()
    {
        Console.WriteLine("Stack contents (top to bottom):");
        foreach (var item in q1.ToArray().Reverse())
            Console.WriteLine(item);
    }

    public bool IsEmpty() => q1.Count == 0;
}