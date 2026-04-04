public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        for(int cursor = 0; cursor < (nums.Length - 1); cursor++)
            if(nums[cursor] == nums[cursor + 1])
                return true;
        return false;
    }
}