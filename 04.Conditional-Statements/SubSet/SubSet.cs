using System;

class SubSet
{
    static bool Check(int[] a, int n, int sum)
    {
        if (a.Length == n)
        {
            return sum == 0;
        }
        if (Check(a, n + 1, sum)) return true;
        if (Check(a, n + 1, sum + a[n])) return true;
        return false;
    }

    static void Main()
    {
        int[] a = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine(Check(a, 0, 0));
    }
}