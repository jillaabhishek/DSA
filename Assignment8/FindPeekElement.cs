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

    public class FindPeekElement
    {
        public int Run()
        {
            //int[] nums = new int[4] { 1, 2, 3, 1 };
            int[] nums = new int[7] { 1, 1, 1, 3, 5, 6, 4 };
            //int[] nums = new int[2] { 2, 1 };
            //int[] nums = new int[3] { 3, 1, 2 };
            //int[] nums = new int[5] { 1, 2, 3, 2, 1 };

            if (nums.Length == 1)
                return 0;

            if (nums.Length == 2)
            {
                if (nums[0] > nums[1])
                    return 0;
                else
                    return 1;
            }

            return ModifiedTwoPonterApproach(nums, 1, nums.Length - 2);

        }


        /// <summary>
        /// O(T) = T(n/2) + c
        /// Using Master Theorem
        /// a = 1, b = 2, k = 0, p =0
        /// log A base B will be 0
        /// Fall in Case 2 and p > -1 
        /// n^k log^p+1n
        /// n^0 logn
        /// O(n) = o(logn)
        /// </summary>
        //Time Complexity: O(logn)
        public int ModifiedTwoPonterApproach(int[] nums, int p, int q)
        {
            if (nums[0] > nums[1])
                return 0;

            if (nums[nums.Length - 1] > nums[nums.Length - 2])
                return nums.Length - 1;

            while (p <= q)
            {
                if (nums[p] > nums[p - 1] && nums[p] > nums[p + 1])
                    return p;
                else
                    p++;

                if (nums[q] > nums[q - 1] && nums[q] > nums[q + 1])
                    return q;
                else
                    q--;
            }

            return -1;
        }


        /// Time Complexity Worst Case : O(n)
        public int FirstApproach(int[] nums)
        {
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
