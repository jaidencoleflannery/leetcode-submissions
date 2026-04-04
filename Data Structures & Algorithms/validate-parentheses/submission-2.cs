public class Solution {
    public bool IsValid(string s) {
        var end_brackets = new Dictionary<char, char> {
            { ')', '(' },
            { '}', '{'},
            { ']', '['}
        };
        Stack<char> charset = new Stack<char>();
        int cursor = 0;
        foreach (char c in s){
            if (end_brackets.ContainsKey(c)) {
                if(cursor == 0) {
                    return false;
                }
                if (charset.Peek() != end_brackets[c]) {
                    return false;
                } else {
                    charset.Pop();
                    cursor--;
                }
            } else {
                charset.Push(c);
                cursor++;
            }
        }
        if(cursor == 0) {
            return true;
        } else {
            return false;
        }
        
    }
}
