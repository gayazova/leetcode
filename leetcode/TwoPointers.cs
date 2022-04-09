﻿namespace leetcode
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
    }
}
