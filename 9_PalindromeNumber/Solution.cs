namespace _9_PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string s = x.ToString();

            return CheckInt(s, 0, s.Length - 1);
        }

        bool CheckInt(string s, int left, int right)
        {
            while (s[left] == s[right] && left != right && left < right)
            {
                left++;
                right--;
            }
            return s[left] == s[right];
        }
    }
}