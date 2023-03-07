public class Solution {
    public int Search(int[] nums, int target) {
        if(!nums.Contains(target))
            return -1;
        
        for(int a=0; a<nums.Length; a++)
        {
            if(nums[a]==target)
                return a;
            
        }
        return -1;
    }
}