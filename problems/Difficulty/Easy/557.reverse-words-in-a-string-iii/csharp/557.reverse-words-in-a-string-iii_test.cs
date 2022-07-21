namespace leetcode.Difficulty.Easy._557.reverse_words_in_a_string_iii.csharp;

using FluentAssertions;
using Xunit;

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
