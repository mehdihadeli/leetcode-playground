# [1.Two Sum](https://leetcode.com/problems/two-sum)

## Description

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

## Example

```csharp
Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,

return [0, 1].
```

## Solution
The optimal time complexity for this problem is O(n).

Sequentially scan the array, for each element, find the other half of the numbers in the map that can combine the given value, and if found, just return the subscripts of the two numbers. If you can't find it, store the number in the map, wait for the "other half" number to be scanned, and then take it out and return the result.

