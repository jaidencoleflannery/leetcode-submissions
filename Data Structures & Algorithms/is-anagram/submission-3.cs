public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        int[] container = new int[26];

        for(int cursor = 0; cursor < s.Length; cursor++) {
            container[s[cursor] - 'a']++;
            container[t[cursor] - 'a']--; 
        }

        foreach(int num in container)
            if(num > 0)
                return false;
        return true;

    }
}
