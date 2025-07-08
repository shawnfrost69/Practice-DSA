namespace Stack_and_Queue;

public class Queue_Using2Stacks
{
    private Stack<int> s1 = new();
    private Stack<int> s2 = new();

    public void Enqueue(int val)
    {
        s1.Push(val);
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue underflow");
        }

        if (s2.Count == 0)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
        }

        return s2.Pop();
    }

    public void PrintQueue()
    {
        Console.WriteLine("Queue Using Two Stacks:");

        foreach (var item in s2)
            Console.WriteLine(item);

        foreach (var item in s1.Reverse())
            Console.WriteLine(item);
    }

    public bool IsEmpty() => s1.Count == 0 && s2.Count == 0;
}