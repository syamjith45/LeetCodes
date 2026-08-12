public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> Set = new HashSet<int>(nums1);
        HashSet<int> Result = new HashSet<int>();
        foreach(int num in nums2){
            if(Set.Contains(num)){
                Result.Add(num);
            }
        }
        return Result.ToArray();
    }
}