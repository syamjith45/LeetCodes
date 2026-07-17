public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int [] count = new int[26];//intial a to z as 0 
        for(int i=0;i<text.Length;i++){
            char c =text[i];
            count[c-'a']++;//b == 0+1
        }
        int b = count['b' - 'a'];
        int a = count['a' - 'a'];
        int l = count['l' - 'a'] / 2;
        int o = count['o' - 'a'] / 2;
        int n = count['n' - 'a'];
        int answer = Math.Min(b, a);
        answer = Math.Min(answer, l);
        answer = Math.Min(answer, o);
        answer = Math.Min(answer, n);

        return answer;
    }
}