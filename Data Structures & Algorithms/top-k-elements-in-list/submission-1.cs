public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var counts = new Dictionary<int, int>();

        foreach (int n in nums) {
            if (!counts.ContainsKey(n)) counts[n] = 0;
            counts[n]++;
        }

        return counts
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}