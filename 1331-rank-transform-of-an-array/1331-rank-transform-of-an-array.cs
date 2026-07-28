public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        int[] sorted = (int[])arr.Clone();
        Array.Sort(sorted);
          Dictionary<int, int> rankMap = new Dictionary<int, int>();
          int rank = 1;
           foreach (int num in sorted)
        {
            // Assign rank only if the number is not already ranked
            if (!rankMap.ContainsKey(num))
            {
                rankMap[num] = rank;
                rank++;
            }
        }
        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = rankMap[arr[i]];
        }
        return result;
    }
}