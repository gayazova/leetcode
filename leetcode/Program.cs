using leetcode.Medium;

namespace leetcode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tws = new TotalWavinessSolution();
            var countMe = tws.TotalWaviness(1234, 1234);
            System.Console.WriteLine(countMe);
            Console.ReadKey();
        }

        private static void TestListNodes()
        {
            var prev = new ListNode(1);
            var head = prev;
            for (int i = 2; i < 4; i++)
            {
                var next = new ListNode(i);
                prev.next = next;
                prev = next;
            }

            PrintListNodes(head);
            var tp = new TwoPointers().MiddleNode(head);
            Console.WriteLine();
            PrintListNodes(tp);
            Console.ReadKey();
        }

        private static void PrintListNodes(ListNode list)
        {
            var current = list;
            while(current != default)
            {
                Console.Write($"{current.val} ");
                current = current.next;
            }
        }
    }
}
