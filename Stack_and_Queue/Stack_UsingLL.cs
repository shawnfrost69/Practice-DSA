using System.Collections.ObjectModel;

namespace Stack_and_Queue;

public class Stack_UsingLL
{
    private class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node top;

    public Stack_UsingLL()
    {
        top = null;
    }

    public void Push(int val)
    {
        Node node = new(val);
        node.Next = top;
        top = node;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack underflow");
        }

        int val = top.Data;
        top = top.Next;
        return val;
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is Empty");
        return top.Data;   
    }

    public void PrintNode()
    {
        Console.WriteLine("Printing LinkedList Stack:");
        Node curr = top;
        while (curr != null)
        {
            Console.WriteLine(curr.Data);
            curr = curr.Next;
        }
    }
    public bool IsEmpty() => top == null;
}