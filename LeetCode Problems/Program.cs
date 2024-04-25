using LeetCode_Problems;

public class Program
{
    static void Main(string[] args)
    {
        #region Object creation - Class - QA
        QA qa = new QA();
        AwayProblems ap = new AwayProblems();
        LeetCode_Problems.Array aPrint = new LeetCode_Problems.Array();
        #endregion

        #region Method - array (declare, initialize and assign)
        aPrint.array();
        #endregion

        #region Method - TwoSum 
        int[] twoSumArray = new int[] {2, 7, 11, 15};

        int[] twoSumArrayOutput = qa.TwoSum(twoSumArray, 9);

        Console.Write("[" + twoSumArrayOutput[0] + ", " + twoSumArrayOutput[1] + "]");
        Console.WriteLine("");
        #endregion

        #region Method - IsPalindrome
        Console.WriteLine(qa.IsPalindrome(-121));
        #endregion

        #region Method - RomanToInt
        Console.WriteLine(qa.RomanToInt("LIV"));
        #endregion

        #region Method - LongestCommonPrefix
        Console.WriteLine(qa.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        #endregion

        #region Method - ValidParentheses
        string parentheses = "{}()[]";
        Console.WriteLine(qa.ValidParentheses(parentheses));
        #endregion

        #region Method - MergeTwoLists
        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(2);
        l1.next.next = new ListNode(4);

        ListNode l2 = new ListNode(1);
        l2.next = new ListNode(3);
        l2.next.next = new ListNode(4);

        ListNode ln = qa.MergeTwoLists(l1, l2);

        while(ln != null)
        {
            Console.Write(ln.val + " ");
            ln = ln.next;
        }
        Console.WriteLine("");
        #endregion

        #region Method - LengthOfLastWord
        Console.WriteLine(qa.LengthOfLastWord("   Moon is a    beautiful creation   "));
        #endregion

        #region Method - PlusOne
        int[] array = new int[]{ 0, 0 };
        int [] arrayOutput = qa.PlusOne(array);
        foreach (var num in arrayOutput)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("");
        #endregion

        #region Method - AddBinary
        Console.WriteLine(qa.AddBinary("11", "1"));
        #endregion

        #region Method - ClimbStairs
        Console.WriteLine(qa.ClimbStairs(1));
        #endregion

        #region Method - MaxProfit
        int[] maxProfit = new int[] { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(qa.MaxProfit(maxProfit));
        #endregion

        #region Method - ValidatePalindrome
        Console.WriteLine(qa.ValidatePalindrome("A man, a plan, a canal: Panama"));
        Console.WriteLine(qa.ValidatePalindrome("race a car"));
        #endregion

        #region Method - ValidateStrictPalindrome
        Console.WriteLine(qa.ValidateStrictPalindrome("MadaM"));
        #endregion

        #region Method - SingleNumber
        Console.WriteLine(qa.SingleNumber(new int[] { 4, 1, 4, 1, 2 }));
        #endregion

        #region Method - titleToNumber
        Console.WriteLine(qa.titleToNumber("AA"));
        #endregion

        #region Method - insertNumberInPlaces [used string.Join(", ", {arrayName})]
        int[] outputArray = ap.insertNumberInPlaces();
        Console.WriteLine("Insert Number in places [" + string.Join(", ", outputArray) + "]");
        //foreach (var item in outputArray)
        //{
        //    Console.Write(item + " ");
        //}
        //Console.WriteLine("");
        #endregion

        #region Method - thirdLargestNumber
        int thirdLargestNumberOutput = ap.thirdLargestNumber(new int[] { 10, 1, 9, 4, 6, 7, 11, 55, 36, 2, 3 });
        Console.WriteLine(thirdLargestNumberOutput);
        #endregion


        #region Object creation - Class - SortingAlgo
        SortingAlgo sortingAlgo = new SortingAlgo();
        Console.WriteLine(sortingAlgo.bubbleSortAlgo(new int[] { 5, 2, 1, 10, 35, 9, 8, 19 }));
        #endregion
    }
}