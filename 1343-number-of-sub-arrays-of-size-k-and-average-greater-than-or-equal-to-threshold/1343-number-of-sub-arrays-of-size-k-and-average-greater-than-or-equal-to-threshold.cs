public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int windowSum =0;
         int count = 0;
        for(int i =0; i<k;i++){
            windowSum+=arr[i];
        }
        if((windowSum/k)>=threshold){
 
            count++;

        }
        for(int i =k;i<arr.Length;i++){
            windowSum = windowSum - arr[i-k]+arr[i];
            if((windowSum/k)>=threshold){
                count++;
            }
        }
        return count;
    }
}