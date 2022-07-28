public class Solution {
    public int NumberOfSteps(int num) {
        int steps = 0;
        int n = num;
        while(n != 0){
            if(n % 2 == 0){
                n = n/2;
            }
            else{
                n--;
            }
            steps++;
        }
        return steps;
    }
}