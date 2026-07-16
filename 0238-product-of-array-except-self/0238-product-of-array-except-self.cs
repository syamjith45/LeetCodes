public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int [] answer = new int[n];
        //store left products
        int leftProduct = 1;
        for(int i =0;i<n;i++){
            answer[i] = leftProduct;
            leftProduct*=nums[i];
        }
        //multiply with right product
        int rightProduct = 1;
        for(int i = n-1;i>=0;i--){
            answer[i]*=rightProduct;
            rightProduct*=nums[i];

        }
        return answer;
    }
}