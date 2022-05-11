namespace IntegerPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            int reverseNumber = 0, number = x;

            while (number > 0)
            {
                int reminder = number % 10;
                reverseNumber = reverseNumber * 10 + reminder;
                number = number / 10;
            }

            return (x == reverseNumber);
        }
    }
}
