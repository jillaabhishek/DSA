using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_8
{
    /// https://leetcode.com/problems/find-peak-element/
    /// <summary>
    /// The peak element is the element that is strictly greater than its neighbors. 
    /// If an array contains multiple peak elements, return the index of any of the peak elements.
    /// For example: [1,2,3,1]
    /// Output: 2

    /// </summary>
    /// Time Complexity Worst Case : O(n)
    public class FindPeekElement
    {
        public int Run()
        {
            int[] nums = new int[4] { 1, 2, 3, 1 };
            //int[] nums = new int[7] { 1, 2, 3, 3, 5, 6, 4 };
            //int[] nums = new int[2] { 2, 1 };
            if (nums.Length == 1)
                return 0;

            int i = 1;
            while (i < nums.Length - 1)
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                    return i;

                if (nums[i] > nums[i + 1])
                    i += 2;
                else
                    i++;
            }

            if (nums[0] > nums[1])
                return 0;

            if (nums[nums.Length - 1] > nums[nums.Length - 2])
                return nums.Length - 1;

            return -1;
        }
    }
}
