namespace leetcode.Medium
{
    public class TotalWavinessSolution
    {
        // 120 и 130
        // 198 и 202
        // 4848 и 4848
        public int TotalWaviness(int num1, int num2)
        {
            var result = 0;

            if (num2 < 100)
                return result;

            for (int i = num1; i <= num2; i++)
            {
                result += CountWaviness(i);
            } 

            return result;
        }

        // вариант потребляет меньше памяти по сравнению с первым вариантом
        private int CountWaviness(int num)
        {
            if (num < 100) return 0;

            var digits = new List<int>();
            while (num > 0)
            {
                digits.Add(num % 10);
                num /= 10;
            }
            digits.Reverse();

            int result = 0;
            for (int i = 1; i < digits.Count - 1; i++)
            {
                if (digits[i] < digits[i - 1] && digits[i] < digits[i + 1]) result++;
                else if (digits[i] > digits[i - 1] && digits[i] > digits[i + 1]) result++;
            }
            return result;
        }

        private int CountWaviness_v1(int num)
        {
            var result = 0;
            var stringNum = num.ToString();

            for (int i = 1; i < stringNum.Length - 1; i++)
            {
                var left = (int)char.GetNumericValue(stringNum[i - 1]);
                var current = (int)char.GetNumericValue(stringNum[i]);
                var right = (int)char.GetNumericValue(stringNum[i + 1]);

                if (current < left && current < right)
                    result++;
                if (current > left && current > right)
                    result++;
            }
            return result;
        }
    }
}
