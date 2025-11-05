public class Solution35Easy
{
    public int SearchInsert(int[] nums, int target)
    {
        int low_index = 0;
        int high_index = nums.Length - 1;
        int mid = 0;

        while (low_index <= high_index)
        {
            int middle_index = low_index + (high_index - low_index) / 2;
            mid = middle_index;

            if (nums[middle_index] == target)
            {
                return middle_index;
            }

            if (nums[middle_index] < target)
            {
                low_index = middle_index + 1;
            }
            else
            {
                high_index = middle_index - 1;
            }
        }

        if (nums[mid] > target)
        {
            return low_index;
        }
        else
        {
            return high_index + 1;
        }
    }
}