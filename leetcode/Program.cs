namespace leetcode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 4, 4, 9, 56, 90 };
            var tp = new TwoPointers();
            var result = tp.TwoSum(nums, 8);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("Errrren Yeageeeeer");
            Console.ReadKey();
        }
    }
}
