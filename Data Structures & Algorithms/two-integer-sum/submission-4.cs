public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hash = new();
        for(int cursor = 0; cursor < nums.Length; cursor++) {
            int diff = (target - nums[cursor]);
            if(hash.ContainsKey(diff))
                return new int[] { hash[diff], cursor };
            hash[nums[cursor]] = cursor;
        }
        return null;
    }
}
