using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    public class SortingAlgo
    {
        public string bubbleSortAlgo(int[] inputArray)
        {
            Console.WriteLine("Bubble Sort:");
            Console.WriteLine("Unsorted Array: [ " + string.Join(", ", inputArray) + " ]");

            int length = inputArray.Length;
            int swap;
            int rounds = 0;
            bool sorted = false;

            while(!sorted)
            {
                sorted = true;

                for(int i = 0; i < length - 1 - rounds; i++)
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        swap = inputArray[i];
                        inputArray[i] = inputArray[i + 1];
                        inputArray[i + 1] = swap;

                        sorted = false;
                    }
                }
                rounds++;
            }

            return "Sorted Array: [ " + string.Join(", ", inputArray) + " ]";
        }
    }
}
