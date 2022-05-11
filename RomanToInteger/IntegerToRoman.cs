using System.Collections.Generic;
using System.Text;

namespace RomanToInteger
{
    public class IntegerToRoman
    {
        Dictionary<int, string> romanMap = new Dictionary<int, string>()
        {
            {1, "I"},
            {5, "V"},
            {10, "X"},
            {50, "L"},
            {100, "C"},
            {500, "D"},
            {1000, "M"}
        };

        public string IntToRoman(int num)
        {
            if (num > 3999 || num < 1)
            {
                return "Invalid value";
            }

            StringBuilder romanNumber = new StringBuilder();
            int x = num / 1000;
            romanNumber.Append(AddValue(x, 1000));
            x = (num % 1000)/100;
            romanNumber.Append(GetValue(x, 100));
            x = (num % 100)/10;
            romanNumber.Append(GetValue(x, 10));
            x = num % 10;
            romanNumber.Append(GetValue(x, 1));
            return romanNumber.ToString();
        }

        private string AddValue(int n, int unit)
        {
            StringBuilder r = new StringBuilder();
            for (int idx = 0; idx < n; idx++)
            {
                r.Append(romanMap[unit]);
            }
            return r.ToString();
        }

        private string GetValue(int x, int unit)
        {
            StringBuilder str = new StringBuilder();
            if (x == 0) return str.ToString();
            if (x >= 5)
            {
                int diff = x - 5;
                if (diff == 4)
                {
                    str.Append(romanMap[unit] + romanMap[unit * 10]);
                }
                else
                {
                    str.Append(romanMap[unit * 5]);
                    str.Append(AddValue(diff, unit));
                }
            }
            else
            {
                if (x == 4)
                {
                    str.Append(romanMap[unit] + romanMap[unit * 5]);
                }
                else
                {
                    str.Append(AddValue(x, unit));
                }
            }
            return str.ToString();
        }
    }
}
