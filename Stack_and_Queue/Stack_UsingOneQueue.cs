namespace Stack_and_Queue;

//Push O(n), Pop O(1)

public class Stack_UsingOneQueue
{
    private Queue<int> q = new();

    public bool IsEmpty() => q.Count == 0;
    
    public void Push(int val)
    {
        q.Enqueue(val);
        int size = q.Count;
        
        for (int i = 0; i < size - 1; i++)
        {
            q.Enqueue(q.Dequeue());
        }
    }

    public int Pop()
    {
        if(IsEmpty())
        {
            throw new InvalidOperationException("Stack Overflow");
        }

        return q.Dequeue();
    }

    public int Peek()
    {
        if(IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty");
        }
        
        return q.Peek();
    }
    
    public void PrintStack()
    {
        Console.WriteLine("Stack contents using SingleQueue (top to bottom):");
        foreach (var item in q)
        {
            Console.WriteLine(item);
        }
    }
}