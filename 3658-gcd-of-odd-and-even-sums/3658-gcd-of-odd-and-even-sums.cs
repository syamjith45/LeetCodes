public class Solution {
    public int GcdOfOddEvenSums(int n) {
        int o =0;
        int e=0;
         o = n * n; //sum of odd number
         e = n * (n + 1);// Sum of first n even numbers
        while(o!=0){
            int r = e%o; // Find the remainder
            e=o; // Move the smaller number 
            o=r;  // Store the remainder for the next iteration
        }
        return e;
    }
}