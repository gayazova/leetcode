namespace leetcode
{
    public class BinarySearch
    {
        //Given an array of integers nums which is sorted in ascending order,
        //and an integer target, write a function to search target in nums.
        //If target exists, then return its index. Otherwise, return -1.
        public int Search(int[] nums, int target)
        {
            var l = -1;
            var r = nums.Length;
            while (l < r - 1)
            {
                var m = (l + r) / 2;
                if (nums[m] < target)
                    l = m;
                else
                    r = m;
            }
            return r <= nums.Length - 1 && nums[r] == target ? r : -1;
        }

        //Input: n = 5, bad = 4
        //Output: 4
        //Explanation:
        //call isBadVersion(3) -> false
        //call isBadVersion(5) -> true
        //call isBadVersion(4) -> true
        //Then 4 is the first bad version.
        public int FirstBadVersion(int n)
        {
            var left = 1;
            var right = n;
            while (left <= right)
            {
                var m = left + (right - left) / 2;
                Console.WriteLine(m);
                if (IsBadVersion(m))
                {
                    right = m - 1;
                }
                else
                {
                    left = m + 1;
                }
            }
            return left;
        }

        //заглушка для проверки
        private bool IsBadVersion(int version)
        {
            return version >= 10;
        }

        //Given a sorted array of distinct integers and a target value, return the index if the target is found.
        ////If not, return the index where it would be if it were inserted in order.
        public int SearchInsert(int[] nums, int target)
        {
            var left = -1;
            var right = nums.Length;
            while (left < right - 1)
            {
                var mid = (left + right) / 2;
                if (nums[mid] == target)
                    return mid;
                if (nums[mid] < target)
                    left = mid;
                else
                    right = mid;
            }
            return right;
        }
    }
}
