using leetcode.Medium;

namespace leetcode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = new ProcessStrSolution_2().ProcessStr("%#bz%xum##i##vzo#pwc*#dkwbh####%uf%s*%cgppqhqa%h#l##o%ij%%cz%iga##e###u%#e####jfwx##%%*x%m*%#", 6523);
            System.Console.WriteLine(result);
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
