namespace Greedy_algorithm;

public class MergeIntervals
{
    public static int[][] Merge(int[][] intervals) {
        if(intervals.Length == 0) return intervals;

        Array.Sort(intervals,(a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();
        int [] current = intervals[0];

        foreach(int[] interval in intervals)
        {
            if(interval[0] <= current[1])
            {
                current[1] = Math.Max(current[1], interval[1]);
            }
            else
            {
                merged.Add(current);
                current = interval; 
            }
        }

        merged.Add(current);
        return merged.ToArray();
    }
}