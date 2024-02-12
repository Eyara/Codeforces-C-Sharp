namespace Codeforces.Practice.Two_Pointer;

/// <summary>
///     https://codeforces.com/contest/1928/problem/B
/// </summary>
public class Problem1928B
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

        var aUnique = a.Distinct().ToList();
        aUnique.Sort();

        var result = 0;
        var pnt = 0;
        for (var i = 0; i < aUnique.Count; i++)
        {
            while (aUnique[i] - aUnique[pnt] >= n) pnt++;

            result = Math.Max(result, i - pnt + 1);
        }

        Console.WriteLine(result);
    }
}