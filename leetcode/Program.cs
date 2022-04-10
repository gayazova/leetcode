namespace leetcode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new char[] { 'h', 'e', 'l', 'l' };
            var str = "Let's take LeetCode contest";
            var tp = new TwoPointers();
            var result = tp.ReverseWords(str);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
