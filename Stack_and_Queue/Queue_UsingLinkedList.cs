namespace Stack_and_Queue;

public class Queue_UsingLinkedList
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

    private Node head;
    private Node tail;
    private int count;

    public void Enqueue(int val)
    {
        Node newNode = new(val);

        if (tail != null)
        {
            tail.Next = newNode;
        }

        tail = newNode;

        if (head == null)
        {
            head = newNode;
        }

        count++;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue underflow");
        }

        int val = head.Data;
        head = head.Next;

        if (head == null)
        {
            tail = null;
        }

        count--;
        return val;
    }

    public void PrintQueue()
    {
        Console.WriteLine("Printing Queue using LL");
        Node curr = head;
        
        while (curr != null)
        {
            Console.WriteLine(curr.Data);
            curr = curr.Next;
        }
    }
    public bool IsEmpty() => head == null;
}