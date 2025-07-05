
class Program
{
    static void Main(string[] args)
    {
         // 1. Subsequence with ASCII
        // Console.WriteLine("Subsequences with ASCII:");
        // SubSeq.SubSeq1("", "ab");

        // // 2. Subsets of an array
        // Console.WriteLine("\nSubsets of array [1, 2]:");
        SubSeq s = new SubSeq();
        // var result = s.SubSet(new int[] { 1, 2, 2 });
        // foreach (var subset in result)
        // {
        //     Console.WriteLine("[" + string.Join(", ", subset) + "]");
        // }

        // // 3. Subsequence list
        // Console.WriteLine("\nSubsequence List of 'abc':");
        // var list = SubSeq.SubSeqList("", "abc");
        // Console.WriteLine("[" + string.Join(", ", list) + "]");

        s.permutation("", "abc");
        var result = s.permutationList("", "abc");
        Console.WriteLine("[\"" + string.Join("\", \"", result) + "\"]");       
        var result1 = s.LetterCombinations("23");
        Console.WriteLine(string.Join(", ", result1));
    } 
}

