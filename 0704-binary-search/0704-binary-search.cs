public class Solution {
    public int Search(int[] nums, int target) {
        if(!nums.Contains(target))
            return -1;
        var c =-1;
        for(int a=0; a<nums.Length; a++)
        {
            if(nums[a]==target)
                c=a;
        }
        return c;
    }
}