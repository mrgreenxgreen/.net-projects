﻿/*
1.Two Sum

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/

public class Solution
{

    static void Main(string[] args)
    {
        Console.WriteLine("hello");
        int[] numbers = new int[]{2,3,4,5,6};
        // foreach(int number in numbers){
        //     Console.WriteLine(number);
        // }
        Solution solution = new Solution();
        int target = 9;
        var x = solution.TwoSum(numbers, target);
        string arrayToString = string.Join(", ", x);
        Console.WriteLine(arrayToString);
    }

     public int[] TwoSum(int[] nums, int target) {
            int[] x = new int[2];
            for(int i = 0; i < nums.Length; i++){
                for(int ii = 0; ii < i; ii++){
                    if(nums[i]+nums[ii]==target){
                        return new int[]{i,ii};
                    }
                }
            }
            return nums;
    }
}
