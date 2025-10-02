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
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
          if (a.Count == 0 || b.Count == 0) return 0;
        int maxA = a.Max();
        int minB = b.Min();
        if (maxA > minB) return 0;
        int count = 0;
        for (int x = maxA; x <= minB; x++)
        {
            bool isMultipleOfA = true;
            foreach (int aa in a)
            {
                if (x % aa != 0)
                {
                    isMultipleOfA = false;
                    break;
                }
            }
            if (!isMultipleOfA) continue;
            bool dividesAllB = true;
            foreach (int bb in b)
            {
                if (bb % x != 0)
                {
                    dividesAllB = false;
                    break;
                }
            }
            if (dividesAllB)
            {
                count++;
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}


    tokens.push_back(str.substr(start));

    return tokens;
}
