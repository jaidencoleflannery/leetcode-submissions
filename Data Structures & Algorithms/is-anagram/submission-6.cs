public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        int[] store = new int[26];
        for(int cursor = 0; cursor < s.Length; cursor++) {
            store[s[cursor] - 'a']++;
            store[t[cursor] - 'a']--;
        }

        foreach(int num in store)
            if(num != 0)
                return false;
        return true;
    }
}
