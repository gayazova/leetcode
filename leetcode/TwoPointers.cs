using System.Text;

namespace leetcode
{
    public class TwoPointers
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            var newArr = new int[nums.Length];
            Array.Copy(nums, newArr, nums.Length);
            if (nums.Length == 1)
                return;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i - k >= 0)
                {
                    nums[i] = newArr[i - k];
                }
                else
                {
                    nums[i] = newArr[nums.Length - k + i];
                }
            }
        }

        public int[] SortedSquares(int[] nums)
        {
            if (nums.Length == 1)
            {
                nums[0] = (int)Math.Sqrt(nums[0]);
                return nums;
            }
            int left = 0, right = 0;
            int[] result = new int[nums.Length];
            while (nums[right] < 0 && right < nums.Length - 1)
                right++;
            if (right == nums.Length - 1 && nums[right] < 0)
            {
                while (right >= 0)
                {
                    result[left++] = nums[right] * nums[right--];
                }
                return result;
            }
            else if (nums[left] >= 0)
            {
                while (left < nums.Length)
                {
                    result[left] = nums[left] * nums[left++];
                }
                return result;
            }
            else
            {
                int index = 0;
                left = right - 1;
                while (left >= 0 && right < nums.Length)
                {
                    if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                    {
                        result[index++] = nums[left] * nums[left--];
                    }
                    else
                    {
                        result[index++] = nums[right] * nums[right++];
                    }
                }
                while (left >= 0)
                {
                    result[index++] = nums[left] * nums[left--];
                }
                while (right < nums.Length)
                {
                    result[index++] = nums[right] * nums[right++];
                }

                return result;
            }
        }

        public void MoveZeroes(int[] nums)
        {
            var iter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[iter] = nums[i];
                    iter++;
                }
            }

            for (int i = iter; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            var leftPointer = 0;
            var rightPointer = numbers.Length - 1;
            int[] result = new int[2];

            while (leftPointer < rightPointer)
            {
                int sum = numbers[leftPointer] + numbers[rightPointer];

                if (sum == target)
                {
                    result[0] = leftPointer + 1;
                    result[1] = rightPointer + 1;
                    return result;
                }
                else if (sum > target)
                {
                    rightPointer--;
                }
                else
                {
                    leftPointer++;
                }
            }

            return result;
        }

        public void ReverseString(char[] s)
        {
            var length = s.Length;
            var midLength = length % 2 == 0 ? length / 2 : length / 2 + 1;
            for (int i = 0; i < midLength; i++)
            {
                var val = s[i];
                s[i] = s[length - 1 - i];
                s[length - 1 - i] = val;
            }
        }

        public string ReverseWords(string s)
        {
            var words = s.Split(' ');
            var result = new List<string>();
            foreach(var w in words)
            {
                var word = new StringBuilder();
                for (int j = w.Length - 1; j >= 0; j--)
                {
                    word.Append(w[j]);
                }
                result.Add(word.ToString());
            }

            return string.Join(" ", result);
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return null;
            if (head.next == null && n == 1)
                return null;

            var link = head;
            var length = 0;
            while (link != null)
            {
                link = link.next;
                length++;
            }

            var removePosition = length - n;
            if (removePosition == 0)
            {
                head = head?.next;
                return head;
            }
            link = head;
            for (int i = 0; i < removePosition; i++)
            {
                if (i != removePosition - 1)
                {
                    link = link.next;
                }
                else
                {
                    var removedNext = link.next?.next;
                    link.next = removedNext;
                    return head;
                }
            }

            return head;
        }

        public ListNode MiddleNode(ListNode head)
        {
            if (head == null)
                return null;
            if (head.next == null)
                return head;
            var length = 0;
            var link = head;
            while (link != null)
            {
                link = link.next;
                length++;
            }

            var position = length / 2;
            link = head;
            for (int i = 0; i <= position; i++)
            {
                if (i == position)
                    return link;
                link = link.next;
            }

            return head;
        }
    }
}
