namespace LeetCode
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var input = x.ToString();

            if (input.Length < 2)
            {
                return true;
            }

            var len = input.Length;
            var half = len-- >> 1;
            var found = true;
            for (int i = 0; i < half; i++)
            {
                if (input[i] != input[len - i])
                {
                    found = false;
                    break;
                }
            }

            return found;
        }
    }
}
