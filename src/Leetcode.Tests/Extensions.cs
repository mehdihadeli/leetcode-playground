namespace Leetcode.Tests;

public static class Extensions
{
    public static int[][] ParseAsArray(this string source)
    {
        var rows = source.Split("],");
        var res = new int[rows.Length][];
        for (int i = 0; i < rows.Length; i++)
        {
            var items = rows[i]
                .Replace("[", "")
                .Replace("]", "")
                .Split(",");
            res[i] = new int[items.Length];
            for (var j = 0; j < items.Length; j++)
            {
                res[i][j] = int.Parse(items[j]);
            }
        }
        return res;
    }
}
