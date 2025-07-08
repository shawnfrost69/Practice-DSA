using System.Drawing;

namespace Stack_and_Queue;

public class Queue_UsingArray
{
    private int[] arr;
    private int front;
    private int rear;
    private int capacity;
    private int count;

    public Queue_UsingArray(int size)
    {
        capacity = size;
        arr = new int[capacity];
        front = 0;
        rear = -1;
        count = 0;
    }

    public void Enqueue(int val)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("Queue Overflow");
        }

        rear = (rear + 1) % capacity;
        arr[rear] = val;
        count++;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue Underflow");
        }

        int val = arr[front];
        front = (front + 1) % capacity;
        count--;
        return val;
    }

    public void PrintQueue()
    {
        Console.WriteLine("Queue using Array:");
        for (int i = 0; i < count; i++)
        {
            int idx = (front + i) % capacity;
            Console.WriteLine(arr[idx]);
        }
    }
    public bool IsFull() => count == capacity;
    public bool IsEmpty() => count == 0;
}