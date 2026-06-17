using System.Text;

namespace leetcode.Medium
{
    public class ProcessStrSolution_2
    {
        public char ProcessStr(string s, long k)
        {
            if (s == null || k < 0)
                return '.';

            long totalLength = 0;
            var operations = new List<(char op, char letter)>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (IsLowerEnglish(c))
                {
                    operations.Add(('c', c));
                    totalLength++;
                }
                else if (c == '*')
                {
                    operations.Add(('*', '\0'));
                    if (totalLength > 0)
                        totalLength--;
                }
                else if (c == '#')
                {
                    operations.Add(('#', '\0'));
                    totalLength *= 2;
                }
                else if (c == '%')
                {
                    operations.Add(('%', '\0'));
                }
            }

            if (k >= totalLength)
                return '.';

            long pos = k;
            for (int i = operations.Count - 1; i >= 0; i--)
            {
                var (op, letter) = operations[i];

                if (op == 'c')
                {
                    if (pos == 0)
                        return letter;
                    pos--;
                }
                else if (op == '*')
                {
                    // При обратном проходе * означает добавление пропущенного символа
                    // Мы не знаем какой символ был удален, поэтому пропускаем
                    // Но нужно скорректировать позицию
                    continue;
                }
                else if (op == '#')
                {
                    long halfLength = totalLength / 2;
                    if (pos >= halfLength)
                        pos -= halfLength;
                    totalLength = halfLength;
                }
                else if (op == '%')
                {
                    // При реверсе позиция зеркалируется
                    pos = totalLength - 1 - pos;
                }
            }

            return '.';
        }

        private bool IsLowerEnglish(char c) => c >= 'a' && c <= 'z';
    }
}
