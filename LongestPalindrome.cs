using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    class LongestPalindrome
    {
        private int maxLen, index, length;
        public string LongestPalindromeSln(string s)
        {
            int len = s.Length;
            if (len < 2)
                return s;
            for (int i = 0; i < len - 1; i++)
            {
                Extend(s, i, i);
                Extend(s, i, i + 1);
            }
            return s.Substring(index, length);
        }

        private void Extend(string s, int i, int j)
        {
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                i--;
                j++;
            }
            if (j - i - 1 > maxLen)
            {
                index = i + 1;
                maxLen = length = j - i - 1;
            }
        }
    }
}