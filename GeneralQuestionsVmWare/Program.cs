namespace GeneralQuestionsVmWare;

class Program
{
    static void Main(string[] args)
    {
        LRUCache lru = new LRUCache(2);

        lru.put(1, 1);
        lru.put(2, 2);
        Console.WriteLine(lru.get(1)); 

        lru.put(3, 3); 
        Console.WriteLine(lru.get(2)); 
        
        lru.put(4, 4); 
        Console.WriteLine(lru.get(1)); 
        Console.WriteLine(lru.get(3)); 
        Console.WriteLine(lru.get(4)); 
    }
}