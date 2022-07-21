# [557. Reverse Words in a String III](https://leetcode.com/problems/reverse-words-in-a-string-iii/)


## Description

Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
**Note:** In the string, each word is separated by single space and there will not be any extra space in the string.

## Example

``` csharp
    Input: "Let's take LeetCode contest"
    Output: "s'teL ekat edoCteeL tsetnoc"
```

## Solution

- Reverse the string, which requires reversing in units of small strings separated by spaces.
- This is a simple question. Reverse each space-separated word according to the meaning of the question.