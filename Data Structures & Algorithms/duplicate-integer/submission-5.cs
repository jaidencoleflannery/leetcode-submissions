public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> store = new();
        foreach(int num in nums)
            if(!store.Add(num))
                return true;
            return false;
    }
}