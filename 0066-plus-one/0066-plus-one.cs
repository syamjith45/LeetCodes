public class Solution {
    public int[] PlusOne(int[] digits) {
        for(int i = digits.Length -1; i>=0;i--){
            // If digit is less than 9, simply add 1 and return
            if(digits[i]<9){
                digits[i]++;
                return digits;
            }
        // If digit is 9, make it 0 and carry to the previous digit
        digits[i]=0;
        }
         // If we reach here, all digits were 9
         int[] result = new int[digits.Length + 1];
         result[0] =1;

         return result;

    }
}