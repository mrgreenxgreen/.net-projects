/*
Given an integer x, return true if x is a
palindrome
, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
*/

public class Solution
{

    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine("Enter number:");
        string number = Console.ReadLine();
        int num = Convert.ToInt32(number);
        Console.WriteLine(solution.IsPalindrome(num));

    }
    public bool IsPalindrome(int xx)
    {

         int ReversedNumber(int x)
        {
            int reversedNumber = 0;
            while (x != 0)
            {
                reversedNumber = reversedNumber * 10 + x % 10;
                x /= 10;
            }
            if (!reversedNumber.Equals(x))
            {
                return reversedNumber;
            }
            return reversedNumber;
        }
        if(ReversedNumber(xx) == xx){
            return true;
        }else{
            return false;
        }


    }
}