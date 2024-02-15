namespace Codeforces.Practice.BinarySearch;

public class Problem706B
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var numbers = Console.ReadLine()?.Split(' ');

        var a = new List<int>();

        for (var i = 0; i < numbers.Length; i++) a.Add(int.Parse(numbers[i]));

        a.Sort();

        var q = int.Parse(Console.ReadLine());

        for (var i = 0; i < q; i++) Solve(a);
    }

    public static void Solve(List<int> a)
    {
        var m = int.Parse(Console.ReadLine());

        var result = BinarySearch(a, m);

        Console.WriteLine(result);
    }

    private static int BinarySearch(List<int> arr, int target)
    {
        int left = 0, right = arr.Count - 1, res = 0;

        while (left <= right)
        {
            var mid = (right - left) / 2 + left;

            if (arr[mid] <= target)
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