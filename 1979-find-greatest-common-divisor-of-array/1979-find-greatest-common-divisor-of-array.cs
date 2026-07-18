public class Solution {
    public int FindGCD(int[] nums) {
         Array.Sort(nums);
        int s = nums[0];
        int l= nums[nums.Length-1];
        while(s!=0){
          int  remainder = l%s;
            l = s;
            s = remainder;
        }
        return l;
        
        
    }
}