namespace leetcode.Difficulty.Easy._1.two_sum.csharp;

using FluentAssertions;
using Xunit;

public class TwoSumTest
{
    [Fact]
    public void Test()
    {
        var res = Solution.TwoSum(new[] {2, 7, 11, 15}, 9);
        var expected = new[] {0, 1};
        res.Should().Equal(expected);
    }
}
