
namespace Leetcode.Tests.Difficulty.Easy;

using FluentAssertions;
using LeetCodeSolutions.Difficulty.Easy;
using Xunit;

public class TwoSumTest
{
    [Fact]
    public void Test()
    {
        var res = new Solution().TwoSum(new[] { 2, 7, 11, 15 }, 9);
        var expected = new[] { 0, 1 };
        res.Should().Equal(expected);
    }
}
