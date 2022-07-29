public class Solution {
    public IList<string> FizzBuzz(int n) {
        int[] arr = new int[n];
        string[] ans = new string[n];
        for(int i = 1; i < n+1; i++){
            ans[i-1] = "" + i;
            if(i % 3 == 0 && i % 5 == 0){
                ans[i-1] = "FizzBuzz";
            }
            else if(i % 3 == 0){
                ans[i-1] = "Fizz";
            }
            else if(i % 5 == 0){
                ans[i-1] = "Buzz";
            }
        }
        return ans;
    }
}