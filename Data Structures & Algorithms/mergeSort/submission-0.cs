// Definition for a pair.
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
    public List<Pair> MergeSort(List<Pair> pairs) {
        // if we've reached the bottom of the branch, return it for sorting
        if(pairs.Count <= 1) {
            return pairs;
        }

        List<Pair> subarr1 = new List<Pair>();
        List<Pair> subarr2 = new List<Pair>();

        int mid = (pairs.Count / 2);

        // .Count returns count starting from 1, so we reduce by 1
        // grab first half of pairs
        for(int i = 0; i < mid; i++) {
            subarr1.Add(pairs[i]);
        }
        // grab second half of pairs
        for(int i = mid; i < pairs.Count; i++) {
            subarr2.Add(pairs[i]);
        }

        // recurse on subarrays if they contain values
        List<Pair> sortedarr1 = new List<Pair>();
        List<Pair> sortedarr2 = new List<Pair>();

        sortedarr1 = this.MergeSort(subarr1);
        sortedarr2 = this.MergeSort(subarr2);
        

        // sort the values returned
        List<Pair> sortedarray = new List<Pair>();

        int curr1 = 0;
        int curr2 = 0;

        while(curr1 < sortedarr1.Count && curr2 < sortedarr2.Count) {
            if(sortedarr1[curr1].Key <= sortedarr2[curr2].Key) {
                sortedarray.Add(sortedarr1[curr1]);
                curr1++;
            } else {
                sortedarray.Add(sortedarr2[curr2]);
                curr2++;
            }
        }

        while(curr1 < sortedarr1.Count) {
            sortedarray.Add(sortedarr1[curr1]);
            curr1++;
        }

        while(curr2 < sortedarr2.Count) {
            sortedarray.Add(sortedarr2[curr2]);
            curr2++;
        }

        return sortedarray;
    }

}
