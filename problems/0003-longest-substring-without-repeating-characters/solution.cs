public class Solution {
    public int LengthOfLongestSubstring(string s) {
        string subString = "";
        int maxLength = 0; // Track the maximum length found

        // We only need one loop moving a single pointer forward
        for (int rp = 0; rp < s.Length; rp++) 
        {
            
            while (subString.Contains(s[rp])) 
            {
                subString = subString.Remove(0, 1); 
            }

            subString += s[rp];

            if (subString.Length > maxLength) 
            {
                maxLength = subString.Length;
            }
            
        }

        return maxLength;
    }
}

