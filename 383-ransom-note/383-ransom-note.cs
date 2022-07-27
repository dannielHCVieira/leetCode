public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        List<char> ransomList = new List<char>(ransomNote);
        List<char> magazineList = new List<char>(magazine);
        bool result = true;
        foreach(char c in ransomList){
            if(!magazineList.Contains(c)){
                result = false;
                break;
            }
            magazineList.Remove(c);
        }
        return result;
    }
}