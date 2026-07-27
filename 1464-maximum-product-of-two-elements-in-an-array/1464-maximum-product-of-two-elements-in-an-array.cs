public class Solution {
    public int MaxProduct(int[] nums) {
        Array.Sort(nums);
        int largest=nums[nums.Length -1];
        int secondLargest=nums[nums.Length -2];
        
        return (largest-1) * (secondLargest-1);
    }
}