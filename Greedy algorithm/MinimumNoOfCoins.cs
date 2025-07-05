namespace Greedy_algorithm;

public class MinimumNoOfCoins
{
    public static List<int> MinCoins(int n)
    {
        List<int> result = new List<int>();
        int[] coins = {1000, 500, 100, 50, 20, 10, 5, 2, 1};
        foreach (int coin in coins)
        {
            while (n >= coin)
            {
                result.Add(coin);
                n -= coin;
            }
        }
        return result;
    }
}