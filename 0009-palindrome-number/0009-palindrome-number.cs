public class Solution {
    public bool IsPalindrome(int x) {
        int reverseNumber = 0;
        int og =x;
        while(x>0){
           int digit  = x%10;
        reverseNumber = (reverseNumber*10) + digit;
          x = x/10;
        }
        if(reverseNumber == og){
            return true;
        }
        return false;
    }
}