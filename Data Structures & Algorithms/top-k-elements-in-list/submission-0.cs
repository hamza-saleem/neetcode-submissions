public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        return freq
            .OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();
    }
}
