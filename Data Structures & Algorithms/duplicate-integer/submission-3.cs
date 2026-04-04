public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hash = new();
        foreach(int num in nums)
            if(!hash.Add(num))
                return true;
        return false;
    }
}