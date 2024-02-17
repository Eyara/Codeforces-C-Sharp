namespace Codeforces.Practice.MathTheory;

public class Problem313B
{
    public static void Main(string[] args)
    {
        var s = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());

        var sumList = new List<int>();
        sumList.Add(0);

        for (var i = 0; i < s.Length - 1; i++)
        {
            sumList.Add(s[i] == s[i + 1] ? 1 : 0);
        }

        var prefixSum = new int[sumList.Count];
        prefixSum[0] = sumList[0];

        for (var i = 1; i < sumList.Count; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + sumList[i];
        }

        for (var i = 0; i < n; i++) Solve(prefixSum);
    }

    public static void Solve(int[] prefiSumList)
    {
        var inp = Console.ReadLine().Split(' ');
        var l = int.Parse(inp[0]) - 1;
        var r = int.Parse(inp[1]) - 1;
        
        Console.WriteLine(prefiSumList[r] - prefiSumList[l]);
    }
}