namespace GeneralQuestionsVmWare;

public class LRUCache
{
    private class DLinkedNode
    {
        public int Key;
        public int Value;
        public DLinkedNode Prev;
        public DLinkedNode Next;

        public DLinkedNode(int key = 0, int value = 0)
        {
            Key = key;
            Value = value;
        }
    }
    
    private Dictionary<int, DLinkedNode> cache = new ();
    private int capacity;
    private int size;

    private DLinkedNode head, tail;
    
    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        this.size = 0;
        
        head  = new DLinkedNode();
        tail = new DLinkedNode();
        head.Next = tail;
        tail.Prev = head;
    }
    
    public int get(int key) 
    {
        if (!cache.ContainsKey(key))
        {
            return -1;
        }

        var node = cache[key];
        moveToHead(node);
        return node.Value;
    }
    
    public void put(int key, int value) {
        if (cache.ContainsKey(key))
        {
            var node = cache[key];
            node.Value = value;
            moveToHead(node);
        }
        else
        {
            var newNode = new DLinkedNode(key, value);
            cache[key] = newNode;
            AddToHead(newNode);
            size++;

            if (size > capacity)
            {
                var tailNode = RemoveTail();
                cache.Remove(tailNode.Key);
                size--;
            }
        }
    }

    private DLinkedNode RemoveTail()
    {
        var node = tail.Prev;
        RemoveNode(node);
        return node;
    }
    private void moveToHead(DLinkedNode node)
    {
        RemoveNode(node);
        AddToHead(node);
    }

    private void RemoveNode(DLinkedNode node)
    {
        var prev = node.Prev;
        var next = node.Next;
        prev.Next = next;
        next.Prev = prev; 
    }

    private void AddToHead(DLinkedNode node)
    {
        node.Prev = head;
        node.Next = head.Next;
        head.Next.Prev = node;
        head.Next = node;
    }
}