// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> QuickSort(List<Pair> pairs) {
        this.QuickSortHelper(pairs, 0, pairs.Count - 1);
        return pairs;
    }

    private void QuickSortHelper(List<Pair> pairs, int start, int end) {
        if(pairs == null || start > end) {
            return;
        }

        int left = start;

        for(int cursor = start; cursor < end; cursor++) {
            if(pairs[cursor].Key < pairs[end].Key) {
                (pairs[left], pairs[cursor]) = (pairs[cursor], pairs[left]);
                left++;
            }
        }

        (pairs[left], pairs[end]) = (pairs[end], pairs[left]);

        this.QuickSortHelper(pairs, start, (left - 1));
        this.QuickSortHelper(pairs, (left + 1), end);
    }
}
