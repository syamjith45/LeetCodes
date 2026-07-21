public class Solution {
    public int FindNumbers(int[] nums) {
            
            int evenNumber=0;
        for(int i=0;i<nums.Length;i++){
            int count =0;
            int temp = nums[i];
            while(temp>0){
                count ++;
                temp = temp/10;
            
            }
            if(count%2 ==0){
                    evenNumber++;
                }
        }
        return evenNumber;
    }
}