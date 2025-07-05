namespace Stack_and_Queue;

public class Stack_Array
{
    private int[] arr;
    private int capacity;
    private int top;

    public Stack_Array(int size)
    {
        arr = new int[size];
        capacity = size;
        top = -1;
    }
    
    //Expression-bodied member syntax
    public bool IsFull() => top == capacity - 1;
    public bool IsEmpty() => top == -1;
    

    public void Push(int value)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("Stack Overflow");
        }
        arr[++top] = value;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty");
        }

        return arr[top--];
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty");
        }

        return arr[top];
    }

    public void PrintStack()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty");
            return;
        }
        Console.WriteLine("Stack element (top to bottom):");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }
}