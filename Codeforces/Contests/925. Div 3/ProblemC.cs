namespace Codeforces.Contests._925._Div_3;

/// <summary>
///     https://codeforces.com/contest/1931/problem/C
/// </summary>
public class ProblemC
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());

        for (var i = 0; i < t; i++) Solve();
    }

    private static void Solve()
    {
        var n = int.Parse(Console.ReadLine());

        var a = new int[n];

        var numbers = Console.ReadLine()?.Split(' ');

        for (var i = 0; i < a.Length; i++) a[i] = int.Parse(numbers[i]);
        
        var left = 0;
        var right = 0;

        for (var i = 0; i < n; i++)
        {
            if (a[i] != a[0]) break;
            left++;
        }
        for (var i = n - 1; i >= 0; i--)
        {
            if (a[i] != a[n - 1]) break;
            right++;
        }

        if (a[0] != a[n - 1])
        {
            Console.WriteLine(n - Math.Max(left, right));
        }
        else
        {
            Console.WriteLine(Math.Max(0, n - (left + right)));
        }
    }
}