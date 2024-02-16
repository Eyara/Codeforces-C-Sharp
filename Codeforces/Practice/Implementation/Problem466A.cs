namespace Codeforces.Practice.MathTheory;

public class Problem466A
{
    public static void Main(string[] args)
    {
        var inp = Console.ReadLine().Split(' ');

        int n = int.Parse(inp[0]), k = int.Parse(inp[1]), a = int.Parse(inp[2]), b = int.Parse(inp[3]);

        if (k * a > b)
        {
            Console.WriteLine(n / k * b + Math.Min(b, n % k * a));
            return;
        }
        Console.WriteLine(n * a);
    }
}