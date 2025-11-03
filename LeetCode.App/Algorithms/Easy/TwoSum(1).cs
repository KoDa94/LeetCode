using System.Globalization;

public class Solution1Easy
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int value = target - nums[i];

            if (dict.ContainsKey(value))
            {
                return new int[] { dict[value], i };
            }
            
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        return Array.Empty<int>();
    }    
}