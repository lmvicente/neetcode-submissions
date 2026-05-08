public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> items = new();
        
        foreach(int num in nums) {
            if(!items.Add(num)) return true;
        }
        return false;
    }
}