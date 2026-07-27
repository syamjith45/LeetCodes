public class Solution {
    public int MaxProduct(int n) {
        int largest =0;
        int secondLargest=0;
        while(n>0){
           int digit = n%10; //extract last digit 
           if(digit>largest){
            secondLargest=largest;
            largest=digit;
           }
           else if(digit>secondLargest){
            secondLargest=digit;
           }
        n=n/10;
        }
        return largest*secondLargest;
    }
}