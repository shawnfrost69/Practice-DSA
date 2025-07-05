// See https://aka.ms/new-console-template for more information

using System.Net;
using Greedy_algorithm;

class Program
{
    static void Main(String[] args)
    {
        // Console.WriteLine("Hello World!");
        // AssignCookies assignCookies = new AssignCookies();
        // int [] cookies = {1,1};
        // int[] childGrred = {1,2,3};
        // var result =assignCookies.Cookies(cookies, childGrred);
        // Console.WriteLine("Number of content children: " + result);
        
        // int[] values = { 60, 100, 120 };
        // int[] weights = { 10, 20, 30 };
        // int W = 50;
        // double maxValue = FractionalKnapSack.fractionalKnapSack(values, weights, W);
        // Console.WriteLine("Maximum value in knapsack: " + maxValue.ToString("F6"));

        // List<int> ans = MinimumNoOfCoins.MinCoins(43);
        // Console.WriteLine("Coin used:");
        //
        // foreach (int coin in ans)
        // {
        //     Console.Write(coin + " ");
        // }
        int[] bill = { 5, 5, 20, 10, 20 };
        Console.WriteLine(LemonadeChange.lemonade(bill));
        
        int[][] intervals = new int[][] {
            new int[] {1,3},
            new int[] {2,6},
            new int[] {8,10},
            new int[] {15,18}
        };
        
        int[][] mergedIntervals = MergeIntervals.Merge(intervals);
        Console.WriteLine("Merged Intervals:");
        foreach (var interval in mergedIntervals) {
            Console.WriteLine($"[{interval[0]},{interval[1]}]");
        }
    }
}