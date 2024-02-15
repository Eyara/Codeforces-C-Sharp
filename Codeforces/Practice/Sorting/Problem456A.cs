namespace Codeforces.Practice.Sorting;

public class Problem456A
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var priceList = new List<int[]>();
        var qualityList = new List<int[]>();

        for (var i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]);

            var tmpList = new[] { i, a, b };

            priceList.Add(tmpList);
            qualityList.Add(tmpList);
        }

        priceList = priceList.OrderBy(x => x[1]).ToList();
        qualityList = qualityList.OrderBy(x => x[2]).ToList();

        for (var i = 0; i < n; i++)
            if (priceList[i][0] != qualityList[i][0])
            {
                Console.WriteLine("Happy Alex");
                return;
            }

        Console.WriteLine("Poor Alex");
    }
}