/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 *
 * https://leetcode.com/problems/two-sum/description/
 *
 * algorithms
 * Easy (45.39%)
 * Likes:    14924
 * Dislikes: 540
 * Total Accepted:    2.9M
 * Total Submissions: 6.4M
 * Testcase Example:  '[2,7,11,15]\n9'
 *
 * Given an array of integers, return indices of the two numbers such that they
 * add up to a specific target.
 *
 * You may assume that each input would have exactly one solution, and you may
 * not use the same element twice.
 *
 * Example:
 *
 *
 * Given nums = [2, 7, 11, 15], target = 9,
 *
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 *
 *
 */


// @lc code=start

namespace leetcode.Difficulty.Easy._1.two_sum.csharp;

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>(nums.Length);
        for (var i = 0; i < nums.Length; i++)
        {
            var curr = nums[i];
            if (map.ContainsKey(curr))
            {
                return new int[] {map[curr], i};
            }

            map[target - nums[i]] = i;
        }

        return null;
    }
}
// @lc code=end
