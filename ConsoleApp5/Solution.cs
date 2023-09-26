using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Solution
    {
        public int GetUnconsequetiveString(string s)
        {
            int maxLength = 1;
            int currentLength = 1;
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != s[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 1;
                }
            }

            maxLength = Math.Max(maxLength, currentLength);

            return maxLength;
        }
        public int MaxNumberConsecutiveLetters(string s)
        {
            int maxLength = 1;
            int currentLength = 1;
            if (string.IsNullOrEmpty (s))
            {
                return 0;
            }
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 1;
                }
            }
            maxLength = Math.Max(maxLength, currentLength);
            return maxLength;
        }

        public int MaxNumberConsecutiveNumbers(string s)
        {
            int maxLength = 1;
            int currentLength = 1;
            int checker = s.Count(char.IsDigit);
            if (checker == 0)
            {
                return 0;
            }
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1] && char.IsDigit(s[i]))
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 1;
                }
            }
            maxLength = Math.Max(maxLength, currentLength);
            return maxLength;
        }
    }
}
