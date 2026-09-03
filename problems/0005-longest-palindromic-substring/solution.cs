public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length == 1)
            return s;

        string t = "^#" + string.Join("#", s.ToCharArray()) + "#$";

        int[] p = new int[t.Length];

        int center = 0;
        int right = 0;

        int maxLength = 0;
        int maxCenter = 0;

        for (int i = 1; i < t.Length - 1; i++)
        {
            int mirror = 2 * center - i;

            if (i < right)
            {
                p[i] = Math.Min(right - i, p[mirror]);
            }

            while (t[i + (1 + p[i])] == t[i - (1 + p[i])])
            {
                p[i]++;
            }

            if (i + p[i] > right)
            {
                center = i;
                right = i + p[i];
            }

            if (p[i] > maxLength)
            {
                maxLength = p[i];
                maxCenter = i;
            }
        }
        int start = (maxCenter - maxLength) / 2;

        return s.Substring(start, maxLength);
    }
}
