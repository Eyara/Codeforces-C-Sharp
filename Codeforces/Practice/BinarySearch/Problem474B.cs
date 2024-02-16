namespace Codeforces.Practice.BinarySearch;

public class Problem474B
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var numbers = Console.ReadLine()?.Split(' ');

        var a = new List<int>();
        var b = new List<int>();

        for (var i = 0; i < numbers.Length; i++) a.Add(int.Parse(numbers[i]));

        for (var i = 0; i < numbers.Length; i++) b.Add(i == 0 ? a[i] : b[i - 1] + a[i]);

        var m = int.Parse(Console.ReadLine());

        numbers = Console.ReadLine()?.Split(' ');
        var q = new List<int>();

        for (var i = 0; i < numbers.Length; i++) q.Add(int.Parse(numbers[i]));

        for (var i = 0; i < m; i++) Solve(b, q[i]);
    }

    public static void Solve(List<int> a, int q)
    {
        var result = BinarySearch(a, q);

        Console.WriteLine(result + 1);
    }

    private static int BinarySearch(List<int> arr, int target)
    {
        int left = 0, right = arr.Count - 1, res = 0;

        while (left <= right)
        {
            var mid = (right - left) / 2 + left;

            if (arr[mid] < target)
            {
                left = mid + 1;
                res = left;
            }
            else
            {
                right = mid - 1;
            }
        }

        return res;
    }
}