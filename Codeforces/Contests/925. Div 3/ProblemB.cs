namespace Codeforces.Contests._925._Div_3;

/// <summary>
///     https://codeforces.com/contest/1931/problem/B
/// </summary>
public class ProblemB
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

        var target = a.Sum() / n;

        var currentStock = 0;

        for (var i = 0; i < n; i++)
        {
            if (a[i] < target && a[i] + currentStock < target)
            {
                Console.WriteLine("NO");
                return;
            }

            currentStock += a[i] - target;

        }
        
        Console.WriteLine("YES");
    }
}