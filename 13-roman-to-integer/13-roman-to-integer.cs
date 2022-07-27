public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>(){
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        Stack<char> sStacked = new Stack<char>(s.ToCharArray());

        int output = 0,
            lastOne = 1;
        foreach(char c in sStacked){
            if(dict[c] < lastOne){
                output -= dict[c];
            }
            else{
                output += dict[c];
            }
            lastOne = dict[c];
        }
        Console.WriteLine(output);
        return output;
    }
}