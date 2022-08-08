public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        SortedList<int, int> orderedRows = new SortedList<int, int>();
        int[] res = new int[k];
        
        for(int i = 0; i < mat.Length; i++){
            orderedRows.Add(countOnes(mat[i])*mat.Length + i, i);
        }
        
        for(int i = 0; i < k; i++){
            res[i] = orderedRows.Values[i];
        }
        
        return res;
    }
    
    public int countOnes(int[] arr){
        int low = 0, high = arr.Length-1, mid = 0;
        while(low != high){
            mid = (low + high)/2;
            if(arr[mid] == 1){
                low = mid + 1;
            }
            else{
                high = mid;
            }
        }
        if(low == arr.Length-1)
            if(arr[low] == 1)
                low++;
        
        return low;
    }
}