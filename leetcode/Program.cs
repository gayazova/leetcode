namespace leetcode
{
    public class Program
    {
        public static void Main(string[] args)
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
