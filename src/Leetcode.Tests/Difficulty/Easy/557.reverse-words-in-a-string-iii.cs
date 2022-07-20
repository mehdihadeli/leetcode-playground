namespace Leetcode.Tests.Difficulty.Easy;

using Xunit;
using FluentAssertions;

public class ReverseWorldsInAStringIii
{
    [Fact]
    public void Test()
    {
        var res =  Solution.ReverseWords("Let's take LeetCode contest");
        var expected = "s'teL ekat edoCteeL tsetnoc";
        res.Should().Be(expected);
    }
}
