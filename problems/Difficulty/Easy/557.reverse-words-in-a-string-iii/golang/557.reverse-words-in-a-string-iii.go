/*
 * @lc app=leetcode id=557 lang=golang
 *
 * [557] Reverse Words in a String III
 *
 * https://leetcode.com/problems/reverse-words-in-a-string-iii/description/
 *
 * algorithms
 * Easy (79.57%)
 * Likes:    3055
 * Dislikes: 183
 * Total Accepted:    487.8K
 * Total Submissions: 613.1K
 * Testcase Example:  `"Let's take LeetCode contest"`
 *
 * Given a string s, reverse the order of characters in each word within a
 * sentence while still preserving whitespace and initial word order.
 *
 *
 * Example 1:
 * Input: s = "Let's take LeetCode contest"
 * Output: "s'teL ekat edoCteeL tsetnoc"
 * Example 2:
 * Input: s = "God Ding"
 * Output: "doG gniD"
 *
 *
 * Constraints:
 *
 *
 * 1 <= s.length <= 5 * 10^4
 * s contains printable ASCII characters.
 * s does not contain any leading or trailing spaces.
 * There is at least one word in s.
 * All the words in s are separated by a single space.
 *
 *
 */

// @lc code=start
package leetcode

import "strings"

func reverseWords(s string) string {
	ss := strings.Split(s, " ")
	for i, s := range ss {
		ss[i] = setback(s)
	}
	return strings.Join(ss, " ")
}

func setback(s string) string {
	bytes := []byte(s)
	i, j := 0, len(bytes)-1
	for i < j {
		bytes[i], bytes[j] = bytes[j], bytes[i]
		i++
		j--
	}
	return string(bytes)
}

// @lc code=end

