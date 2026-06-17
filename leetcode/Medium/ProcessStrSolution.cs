using System.Text;

namespace leetcode.Medium
{

    /*
        A '*' removes the last character from result, if it exists.
        A '#' duplicates the current result and appends it to itself.
        A '%' reverses the current result.
     */
    public class ProcessStrSolution
    {
        public string ProcessStr(string s)
        {
            var result = new StringBuilder();
            if (s == null)
                return result.ToString();

            for (int i = 0; i < s.Length; i++)
            {
                var charValue = s[i];
                if (IsLowerEnglish(charValue))
                {
                    result.Append(charValue);
                    continue;
                }
                if (charValue == '*')
                {
                    var length = result.Length;
                    if (length < 1)
                        continue;
                    result.Remove(length - 1, 1);
                    continue;
                }
                if (charValue == '#')
                {
                    result.Append(result);
                    continue;
                }
                if (charValue == '%')
                {
                    Reverse(result);
                }
            }

            return result.ToString();
        }

        bool IsLowerEnglish(char c) => c >= 'a' && c <= 'z';

        private void Reverse(StringBuilder sb)
        {
            for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
            {
                char temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;
            }
        }

    }
}
