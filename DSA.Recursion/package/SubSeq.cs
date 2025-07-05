using System;
using System.Collections.Generic;

public class SubSeq
{

    public void permutation(string p, string up)
    {
        if(string.IsNullOrEmpty(up))
        {
            System.Console.WriteLine(p);
            return;
        }

        char ch = up[0];
        for(int i =0; i <= p.Length; i++)
        {
            string f = p.Substring(0, i);
            string s = p.Substring(i);
            permutation(f + ch + s, up.Substring(1));
        }
    }

    public List<string> permutationList(string p, string up)
    {
        if(string.IsNullOrEmpty(up))
        {
            List<string> list = new List<string>();
            list.Add(p);
            return list;
        }

        char ch = up[0];
        List<string> ans = new List<string>();

        for(int i =0; i <= p.Length; i++)
        {
            string f = p.Substring(0, i);
            string s = p.Substring(i);
            ans.AddRange(permutationList(f + ch + s, up.Substring(1)));
        }

        return ans;
    }
    // 1. Print all subsequences with ASCII included
    public static void SubSeq1(string p, string up)
    {
        if (string.IsNullOrEmpty(up))
        {
            Console.WriteLine(p);
            return;
        }

        char ch = up[0];

        // Include the character
        SubSeq1(p + ch, up.Substring(1));
        
        // Exclude the character
        SubSeq1(p, up.Substring(1));
        
        // Include ASCII value of character
        SubSeq1(p + ((int)ch).ToString(), up.Substring(1));
    }

    // 2. Return all subsets of an array
    public List<List<int>> SubSet(int[] arr)
    {
        List<List<int>> outer = new List<List<int>>();
        outer.Add(new List<int>()); // Empty subset

        foreach (int num in arr)
        {
            int n = outer.Count;
            for (int i = 0; i < n; i++)
            {
                List<int> subList = new List<int>(outer[i]);
                subList.Add(num);  // Add current number to subset
                outer.Add(subList);
            }
        }
        return outer;
    }

    // 3. Return all string subsequences as a list
    public static List<string> SubSeqList(string p, string up)
    {
        if (string.IsNullOrEmpty(up))
        {
            List<string> list = new List<string>();
            list.Add(p);
            return list;
        }

        char ch = up[0];
        List<string> left = SubSeqList(p + ch, up.Substring(1));
        List<string> right = SubSeqList(p, up.Substring(1));

        left.AddRange(right);
        return left;
    }

     public static string[] map = {
        "",     // 0
        "",     // 1
        "abc",  // 2
        "def",  // 3
        "ghi",  // 4
        "jkl",  // 5
        "mno",  // 6
        "pqrs", // 7
        "tuv",  // 8
        "wxyz"  // 9
    };
    
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) return new List<string>();

        return NumPad("",digits);
    }

    public static IList<string> NumPad(string p, string up)
    {
        if(string.IsNullOrEmpty(up))
        {
            return new List<string>{p};
        }

        int digit = up[0] -'0';
        string letters = map[digit];

        List<string> ans = new List<string>();

        foreach(char ch in letters)
        {
            ans.AddRange(NumPad(p + ch, up.Substring(1)));
        }

        return ans;
    }
}
