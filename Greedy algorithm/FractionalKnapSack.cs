namespace Greedy_algorithm;

class Item
{
    public int Value;
    public int Weight;

    public Item(int val, int weight)
    {
        Value = val;
        Weight = weight;
    }
}
public class FractionalKnapSack
{
    public static double fractionalKnapSack(int[] values, int[] weights, int w)
    {
        int n = values.Length;
        Item[] items = new Item[n];

        for (int i = 0; i < n; i++)
        {
            items[i] = new Item(values[i], weights[i]);
        }
        
        Array.Sort(items, (a, b) =>
        {
            double r1 = (double)a.Value / a.Weight;
            double r2 = (double)b.Value / b.Weight;

            return r2.CompareTo(r1);
        });
        
        double totalValue = 0.0;
        int currentWeight = 0;

        foreach (var item in items)
        {
            if (currentWeight + item.Weight <= w)
            {
                currentWeight += item.Weight;
                totalValue += item.Value;
            }
            else
            {
                int remaining = w - item.Weight;
                totalValue += ((double)item.Value/ item.Weight) * remaining;
                break;
            }
        }
        return totalValue;
    }
}