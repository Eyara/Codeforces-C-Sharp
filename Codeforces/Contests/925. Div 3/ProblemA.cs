namespace Codeforces.Contests._925._Div_3;

/// <summary>
///     https://codeforces.com/contest/1931/problem/0
/// </summary>
public class ProblemA
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());

        for (var i = 0; i < t; i++) Solve();
    }

    private static void Solve()
    {
        var latinList = new List<char>();
        for (var i = 'A'; i <= 'Z'; ++i) latinList.Add(i);

        var n = int.Parse(Console.ReadLine());

        var result = string.Empty;

        var currentN = n;
        for (var i = 1; i <= 3; i++)
        {
            var currentIdx = 26;
            while (currentIdx >= 0)
            {
                if (i != 3)
                {
                    if (currentN - currentIdx > 3 - i - 1 && currentN - currentIdx <= 26 * (3 - i))
                    {
                        currentN -= currentIdx;
                        result += latinList[currentIdx - 1];
                        break;
                    }
                }
                else
                {
                    result += latinList[currentN - 1];
                    break;
                }

                currentIdx--;
            }
        }

        Console.WriteLine(Reverse(result.ToLower()));
    }

    public static string Reverse(string s)
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}