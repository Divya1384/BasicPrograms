using System.Collections.Generic;

namespace RomanToInteger
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int number = 0;
            Dictionary<char, int> romanMap = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            for (int idx = 0; idx < s.Length; idx++)
            {
                if (idx + 1 < s.Length && romanMap[s[idx]] < romanMap[s[idx + 1]])
                {
                    number -= romanMap[s[idx]];
                }
                else
                {
                    number += romanMap[s[idx]];
                }
            }
            return number;
        }
    }
}
