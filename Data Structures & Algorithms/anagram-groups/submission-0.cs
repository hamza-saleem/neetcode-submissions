public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string word in strs) 
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string sortedWord = new string(chars);

            if (!anagramGroups.ContainsKey(sortedWord)) 
            {
                anagramGroups[sortedWord] = new List<string>();
            }
            anagramGroups[sortedWord].Add(word);
        }

        return new List<List<string>>(anagramGroups.Values);
    }
}


