namespace Codeforces.Practice.MathTheory;

public class Problem1352C
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++) Solve();
    }

    public static void Solve()
    {
        var inp = Console.ReadLine().Split(' ');

        int n = int.Parse(inp[0]), k = int.Parse(inp[1]);
        
        Console.WriteLine(k + (k - 1) / (n - 1));
    }
}