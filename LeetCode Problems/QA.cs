using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    #region Array - Define, Declare, Initialize.
    public class Array {
        public void array()
        {
            int[] numbers; // array declared but size of an array is not initialzed 
            numbers = new int[2]; // size for an array is declared, by default 0 will be stored.

            //assiging values 
            numbers[0] = 1;
            numbers[1] = 2;

            foreach (var item in numbers)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
    #endregion

    #region Class - Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    #endregion

    #region LeetCode QA
    public class QA
    {
        #region return the array of index having the sum of target
        public int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[] { 0, 0 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output[0] = i;
                        output[1] = j;
                    }
                }
            }
            return output;
        }
        #endregion

        #region Palindrome for Integer
        public bool IsPalindrome(int x)
        {
            int rem, sum = 0;
            int temp = x;
            while (x > 0)
            {
                rem = x % 10;
                sum = (sum * 10) + rem;
                x = x / 10;
            }

            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Roman Number to Integer
        public int RomanToInt(string s)
        {
            int result = 0, previous = 0;
            Dictionary<char, int> romanNum = new Dictionary<char, int>{
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1}
            };

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (previous <= romanNum[s[i]])
                {
                    result += romanNum[s[i]];
                }
                else if (previous > romanNum[s[i]])
                {
                    result -= romanNum[s[i]];
                }
                previous = romanNum[s[i]];
            }
            return result;
        }
        #endregion

        #region Longest Common Prefix
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            string prefix = strs[0];

            for (int i = 0; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (prefix.Length == 0)
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }
        #endregion

        #region Valid Parentheses
        public bool ValidParentheses(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;

        }
        #endregion

        #region Merge Two Lists (Single-linked List) ListNode Class
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            if (l1 != null)
            {
                current.next = l1;
            }
            else
            {
                current.next = l2;
            }

            return dummy.next;
        }
        #endregion

        #region Length of last word in a string
        public int LengthOfLastWord(string s)
        {
            int length = 0;

            int i = s.Length - 1;

            // to skip trailing spaces from the right side of the input string
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            // counting last word characters
            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }

            return length;
        }
        #endregion

        #region Plus One to a int[] array
        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                digits[i]++;

                if (digits[i] < 10)
                {
                    return digits;
                }
                digits[i] = 0;
            }

            int[] result = new int[n + 1];
            result[0] = 1;

            return result;
        }
        #endregion

        #region Add Binary from a string input
        public string AddBinary(string a, string b)
        {
            var sum = new List<int>();
            for (int i = a.Length - 1, j = b.Length - 1, carry = 0; i >= 0 || j >= 0 || carry > 0;)
            {
                var firstDigit = i >= 0 ? a[i--] - '0' : 0;
                var secondDigit = j >= 0 ? b[j--] - '0' : 0;
                var sumDigit = firstDigit + secondDigit + carry;
                carry = sumDigit / 2;
                sum.Add(sumDigit % 2);
            }
            sum.Reverse();
            return String.Concat(sum);
        }
        #endregion

        #region Climb Stairs
        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;

            int[] ways = new int[n + 1];
            ways[1] = 1; // There's only one way to climb 1 step
            ways[2] = 2; // There are two ways to climb 2 steps (1 + 1 step or directly 2 steps)

            // Use dynamic programming to calculate the number of ways to climb n steps
            for (int i = 3; i <= n; i++)
            {
                // To reach the i-th step, you can either come from (i-1)-th step or (i-2)-th step
                // So, the total number of ways to reach the i-th step is the sum of ways to reach (i-1)-th and (i-2)-th steps
                ways[i] = ways[i - 1] + ways[i - 2];
            }

            return ways[n];
        }
        #endregion

        #region Best time to buy and sell stock
        #region Works fine but if the array is too long takes time
        //public int MaxProfit(int[] prices)
        //{
        //    int maxProfit = 0;

        //    for (int i = prices.Length - 1; i > 0; i--)
        //    {
        //        for (int j = i; j >= 0; j--)
        //        {
        //            if (prices[i] - prices[j] > maxProfit)
        //            {
        //                maxProfit = prices[i] - prices[j];
        //            }
        //        }
        //    }
        //    return maxProfit;
        //}
        #endregion

        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 2)
            {
                return 0;
            }

            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }

            return maxProfit;
        }
        #endregion

        #region Validate a string is palindrome or not
        public bool ValidatePalindrome(string s)
        {
            if (s.Length == 0)
            {
                return false;
            }
            string pattern = "[^a-zA-Z0-9]"; // ^ - not , to have alphanumberic values
            s = Regex.Replace(s, pattern, "").ToLower(); // comment the line if you are not allowed to use Regex to remove special character
            //s = s.ToLower(); // uncomment the line if you are not allowed to use Regex to remove special character
            int left = 0;
            int right = s.Length - 1;

            while(left < right)
            {
                # region if you are not allowed to use Regex to remove special character
                //while (left < right && !char.IsLetterOrDigit(s[left]))
                //    left++;
                //while (left < right && !char.IsLetterOrDigit(s[right]))
                //    right--;
                #endregion

                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;          
        }
        #endregion

        #region Validate a string is strict palindrome or not
        public bool ValidateStrictPalindrome(string s)
        {
            if(s.Length <= 0)
            {
                return false;
            }

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if ((int)s[left] != (int)s[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        #endregion

        #region Single Number in a array
        public int SingleNumber(int[] nums)
        {
            int k = 0;

            if (nums.Length == 1)
            {
                return nums[0];
            }
            else
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[k] == nums[i])
                    {
                        int temp = nums[k + 1];
                        nums[k + 1] = nums[i];
                        nums[i] = temp;
                        k = k + 2;
                        i = k;
                    }
                }
            }
            return nums[k];
        }
        #endregion

        #region To find the index number of Excel using the column name
        public int titleToNumber(string columnTitle)
        {
            int result = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                char ascii = columnTitle[i];
                int value = ascii - 'A' + 1;
                result = result * 26 + value;
            }
            return result;
        }
        #endregion
    }
    #endregion

    #region Away Problems
    public class AwayProblems
    {
        #region add number before each array index, 0 before first n = 4 elements in array, 1 for 2nd four elements
        public int[] insertNumberInPlaces()
        {
            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] outputArray = new int[inputArray.Length * 2] ;
            int insertValue = 0;
            int indexLastUpdated = -1;

            for(int i = 0; i <= inputArray.Length - 1; i++)
            {
                indexLastUpdated++;
                outputArray[indexLastUpdated] = insertValue;
                indexLastUpdated++;
                outputArray[indexLastUpdated] = inputArray[i];

                if( (i + 1) % 4 == 0)
                {
                    insertValue++;
                }
            }
            return outputArray;
        }
        #endregion

        #region to find the third largest number in a unsorted array
        public int thirdLargestNumber(int[] inputArray)
        {
            #region BubbleSort - there is no need to iterate entire array, we can end the rounds = largest nth element which to find
            int length = inputArray.Length;
            int swap;
            int rounds = 0;
            bool order = false;

            while (!order && rounds < 3) // added condition to end the while loop 
            {
                order = true;

                for (int i = 0; i < length - 1 - rounds; i++)
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        swap = inputArray[i];
                        inputArray[i] = inputArray[i + 1];
                        inputArray[i + 1] = swap;

                        order = false;
                    }
                }
                rounds++;
            }
            #endregion
            Console.WriteLine("[ " + string.Join(", ", inputArray) + "]");
            int thirdLargestNumber = inputArray[length - 3];

            return thirdLargestNumber;
        }
        #endregion
    }
    #endregion
}
