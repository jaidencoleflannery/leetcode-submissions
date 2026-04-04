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
        this.quickSortHelper(pairs, 0, (pairs.Count - 1));
        return pairs;
    }

    private void quickSortHelper(List<Pair> pairs, int start, int end) {
        if((end - start + 1) <= 1) {
            return;
        }

        Pair pivot = pairs[end];
        int left = start;

        for(int cursor = start; cursor < end; cursor++) {
            if(pairs[cursor].Key < pivot.Key) {
                var tmp = pairs[left];
                pairs[left] = pairs[cursor];
                pairs[cursor] = tmp;
                left++;
            }
        }

        pairs[end] = pairs[left];
        pairs[left] = pivot;

        this.quickSortHelper(pairs, start, left - 1);
        this.quickSortHelper(pairs, left + 1, end);
    }
}
