using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'almostSorted' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void almostSorted(List<int> arr)
    {
        var sortedArr = arr.Order().ToList();
        int difference = 0;
        var items = new List<int>();

        for (int i = 0; i < sortedArr.Count(); i++)
        {
            if (arr[i] != sortedArr[i]) { items.Add(arr[i]); difference++; }
        }

        if (difference == 2) { Console.WriteLine("yes"); Console.WriteLine($"swap {arr.IndexOf(items[0])+1} {arr.IndexOf(items[1])+1}"); }
        else if (IsReversed(items)) { Console.WriteLine("yes"); Console.WriteLine($"reverse {arr.IndexOf(items.Max()) + 1} {arr.IndexOf(items.Min()) + 1}"); }
        else { Console.WriteLine("no"); }
    }

    private static bool IsReversed(List<int> arr) 
    {
        var sortedarr = arr.OrderBy(x => x).ToList();
 
        for (int i = 0; i < sortedarr.Count; i++)
        {
            if (arr[i] != sortedarr[arr.Count - i - 1])
            {
                return false;
            }
        }

        return true;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.almostSorted(arr);
    }
}
